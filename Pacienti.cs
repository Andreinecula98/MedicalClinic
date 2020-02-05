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
    public partial class Pacienti : Form
    {
        public Pacienti()
        {
            InitializeComponent();
        }

        private void Pacienti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vizite1.Pacienti' table. You can move, or remove it, as needed.
            this.pacientiTableAdapter.Fill(this.vizite1.Pacienti);
         
           new ViziteTableAdapters.PacientiTableAdapter().Fill(vizite1.Pacienti);
        }

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

     

        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new ViziteTableAdapters.PacientiTableAdapter().Update(vizite1.Pacienti);
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            Vizite.PacientiRow row = gridView1.GetFocusedDataRow() as Vizite.PacientiRow;

            //DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
      

            if (row.IsNumeNull())
            {
                e.Valid = false;
                string err = "You need to text something!";
                e.ErrorText = err;
                gridView1.SetColumnError(colNume, err);
            }


        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            Vizite.PacientiRow randPac = gridView1.GetFocusedDataRow() as Vizite.PacientiRow;
            Informatii info = new Informatii(randPac.ID_pacient);
            info.Show();
        }
    }
}
