using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AesEncDec;
using System.IO;

namespace ClinicaMed
{
    public partial class Register : Form
    {

        string conncetionString = Properties.Settings.Default.ClinicaMedConnectionString; // @"Data Source=10.10.20.61;Initial Catalog=ClinicaMed;Persist Security Info=True;User ID=clin;Password=clin";

        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(conncetionString))
            {
                if (string.IsNullOrEmpty(txtpass.Text))
                {
                    MessageBox.Show("Please enter a password!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                sqlCon.Open();
                SqlCommand sqlCom = new SqlCommand("UserAdd", sqlCon);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.AddWithValue("@Nume", txtN1.Text.Trim());
                sqlCom.Parameters.AddWithValue("@Prenume", txtP1.Text.Trim());
                sqlCom.Parameters.AddWithValue("@Parola", AesEncDec.Aes.Encrypt(txtpass.Text.Trim()));
                sqlCom.Parameters.AddWithValue("@Id_rol", get_default_id_rol());
                sqlCom.ExecuteNonQuery();

                if (txtN1.Text == "" || txtP1.Text == "" || txtpass.Text == "")
                {
                    MessageBox.Show("Fail!Please complete all the blanckets!");
                }
                else
                {
                    MessageBox.Show("Registration is Successfull");
                    Clear();
                    this.Hide();
                    Login l = new Login();
                    l.Show();
                } 
               

            }
               

        }
        void Clear()
        {
            txtN1.Text = txtP1.Text = txtpass.Text = " ";
        }

        int get_default_id_rol()
        {
            int rez=-1;
            using (SqlConnection sqlCon = new SqlConnection(conncetionString))
            {
                sqlCon.Open();
                SqlCommand sqlCom = new SqlCommand("select Id_rol from Roluri where Implicit=1", sqlCon);
                sqlCom.CommandType = CommandType.Text;
                rez = Convert.ToInt32(sqlCom.ExecuteScalar());  
            }
            return rez;
        }
        private void btncancel_Click(object sender, EventArgs e)
        { 
            this.Close();
            this.Hide();
            Login l = new Login();
            l.Show();
        }

       
    }
}
