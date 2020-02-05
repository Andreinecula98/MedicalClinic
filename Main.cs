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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void barBtnPacienti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Pacienti pac = new Pacienti();
            pac.MdiParent = this;
            pac.Show();
        }


        private void barBtnSpecialitati_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClinicaMed.Specialitati spec = new Specialitati();
            spec.MdiParent = this;
            spec.Show();
        }

     
        private void barButtonDiagnostice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClinicaMed.Diagnostice diag = new Diagnostice();
            diag.MdiParent = this;
            diag.Show();
        }

        private void barButtonServicii_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClinicaMed.Servicii_Medicale serv = new Servicii_Medicale();
            serv.MdiParent = this;
            serv.Show();

        }


        private void barBtnMedici_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Medici med = new Medici();
            med.MdiParent = this;
            med.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Programari prog = new Programari();
            prog.MdiParent = this;
            prog.Show();
        }
    }
}
