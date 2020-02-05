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
    public partial class Medici : Form
    {
        public Medici()
        {
            InitializeComponent();
        }

        private void Medici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vizite.Pacienti' table. You can move, or remove it, as needed.
            this.pacientiTableAdapter.Fill(this.vizite.Pacienti);
            // TODO: This line of code loads data into the 'nomDs.Specialitati' table. You can move, or remove it, as needed.
            this.specialitatiTableAdapter.Fill(this.nomDs.Specialitati);
            // TODO: This line of code loads data into the 'vizite.Medici' table. You can move, or remove it, as needed.
            this.mediciTableAdapter.Fill(this.vizite.Medici);

            new ViziteTableAdapters.MediciTableAdapter().Fill(vizite.Medici);

            new NomTableAdapters.SpecialitatiTableAdapter().Fill(nomDs.Specialitati);

        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
          
            Vizite.MediciRow row = gridView1.GetFocusedDataRow() as Vizite.MediciRow;

            //DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            //if (view.FocusedColumn.FieldName == "Nume")

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

        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            new ViziteTableAdapters.MediciTableAdapter().Update(vizite.Medici);
        }

       
    }
}
