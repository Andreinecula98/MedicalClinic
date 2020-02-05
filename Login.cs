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
    public partial class Login : Form
    {
        string conncetionString = Properties.Settings.Default.ClinicaMedConnectionString;

        public Login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            
                using (SqlConnection sqlCon = new SqlConnection(conncetionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From dbo.Utilizatori where Nume='" + txtNume.Text + "' and Prenume ='" + txtPrenume.Text + "' and Parola='" + AesEncDec.Aes.Encrypt(txtParola.Text) + "'", sqlCon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        Main nou = new Main();
                        nou.Show();

                    }
                    else
                    {
                        MessageBox.Show("Incorect!");
                    }
                }
            
        }



        private void btnregister_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Register r = new Register();
            r.Show();
        }
       
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
    
}
