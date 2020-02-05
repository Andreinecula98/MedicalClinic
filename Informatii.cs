using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMed
{
    public partial class Informatii : Form
    {

        string PacientNume
        {
            get
            {
                return txNume.Text;
            }
            set
            {
                txNume.Text = value;
            }
        }

        string PacientPrenume
        {
            get
            {
                return txPrenume.EditValue.ToString();
            }
            set
            {
                txPrenume.EditValue = value;
            }
        }


        string MedicNume
        {
            get
            {
                return txNumeM.EditValue.ToString();
            }
            set
            {
                txNumeM.EditValue = value;
            }
        }

        string MedicPrenume
        {
            get
            {
                return txPrenumeM.EditValue.ToString();
            }
            set
            {
                txPrenumeM.EditValue = value;
            }
        }

        DateTime DataVizita
        {
            get
            {
                return dateEdit1.DateTime;
            }
            set
            {
                dateEdit1.EditValue = value;
            }
        }


        public Informatii()
        {
            InitializeComponent();
        }

        public Informatii(int pacient_id)
        {
            
            InitializeComponent();

            new ViziteTableAdapters.PacientiTableAdapter().FillByID_Pacient(vizite1.Pacienti, pacient_id);
            new ViziteTableAdapters.Vizite_medicaleTableAdapter().FillBy(vizite1.Vizite_medicale, pacient_id);

            if (vizite1.Pacienti.Rows.Count > 0)
            {
                PacientNume = vizite1.Pacienti[0]["Nume"].ToString();
                PacientPrenume = vizite1.Pacienti[0]["Prenume"].ToString();


            }

            if (vizite1.Vizite_medicale.Rows.Count > 0)
            {
                MedicNume = vizite1.Vizite_medicale[0]["Nume"].ToString();
                MedicPrenume = vizite1.Vizite_medicale[0]["Prenume"].ToString();
                if (vizite1.Vizite_medicale[0]["Dataa"] != DBNull.Value)
                    DataVizita = Convert.ToDateTime(vizite1.Vizite_medicale[0]["Dataa"]);
            }




        }

        private void txNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void txPrenume_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txNumeM_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txPrenumeM_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
