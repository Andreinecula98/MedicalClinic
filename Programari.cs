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
    public partial class Programari : Form
    {
        public Programari()
        {
            InitializeComponent();
        }

        private void Programari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vizite2.Pacienti' table. You can move, or remove it, as needed.
            this.pacientiTableAdapter.Fill(this.vizite1.Pacienti);
            // TODO: This line of code loads data into the 'nom1.Specialitati' table. You can move, or remove it, as needed.
       
            this.programariTableAdapter.Fill(this.vizite1.Programari);

           new ViziteTableAdapters.PacientiTableAdapter().Fill(vizite1.Pacienti);


            new ViziteTableAdapters.ProgramariTableAdapter().Fill(vizite1.Programari);
        }

        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            new ViziteTableAdapters.ProgramariTableAdapter().Update(vizite1.Programari);
        }

        private void GridControl1_Click(object sender, EventArgs e)
        {

        }

        //private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        //{


        //    Vizite.Programari row = gridView1.GetFocusedDataRow() as Vizite.ProgramariRow;
        //    //DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
        //    //if (view.FocusedColumn.FieldName == "Nume")

        //    if (row.IsNumeNull())
        //    {
        //        e.Valid = false;
        //        string err = "You need to text something!";
        //        e.ErrorText = err;
        //        gridView1.SetColumnError(colNume, err);
        //    }


        //}

        //private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        //{
        //    e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
        //}
    }
}
