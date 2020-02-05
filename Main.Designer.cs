namespace ClinicaMed
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnPacienti = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnMedici = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSpecialitati = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDiagnostice = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonServicii = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Nomenclaturi = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowCustomization = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barBtnPacienti,
            this.barBtnMedici,
            this.barBtnSpecialitati,
            this.barButtonDiagnostice,
            this.barButtonServicii,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsCustomizationForm.AllowLinkCustomization = true;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.Nomenclaturi});
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 141);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barBtnPacienti
            // 
            this.barBtnPacienti.Caption = "Pacienti";
            this.barBtnPacienti.Id = 1;
            this.barBtnPacienti.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnPacienti.ImageOptions.Image")));
            this.barBtnPacienti.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnPacienti.ImageOptions.LargeImage")));
            this.barBtnPacienti.Name = "barBtnPacienti";
            this.barBtnPacienti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPacienti_ItemClick);
            // 
            // barBtnMedici
            // 
            this.barBtnMedici.Caption = "Medici";
            this.barBtnMedici.Id = 2;
            this.barBtnMedici.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnMedici.ImageOptions.Image")));
            this.barBtnMedici.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnMedici.ImageOptions.LargeImage")));
            this.barBtnMedici.Name = "barBtnMedici";
            this.barBtnMedici.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnMedici_ItemClick);
            // 
            // barBtnSpecialitati
            // 
            this.barBtnSpecialitati.Caption = "Specialitati";
            this.barBtnSpecialitati.Id = 3;
            this.barBtnSpecialitati.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSpecialitati.ImageOptions.Image")));
            this.barBtnSpecialitati.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSpecialitati.ImageOptions.LargeImage")));
            this.barBtnSpecialitati.Name = "barBtnSpecialitati";
            this.barBtnSpecialitati.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSpecialitati_ItemClick);
            // 
            // barButtonDiagnostice
            // 
            this.barButtonDiagnostice.Caption = "Diagnostice";
            this.barButtonDiagnostice.Id = 4;
            this.barButtonDiagnostice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonDiagnostice.ImageOptions.Image")));
            this.barButtonDiagnostice.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonDiagnostice.ImageOptions.LargeImage")));
            this.barButtonDiagnostice.Name = "barButtonDiagnostice";
            this.barButtonDiagnostice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDiagnostice_ItemClick);
            // 
            // barButtonServicii
            // 
            this.barButtonServicii.Caption = "Servicii_Medicale";
            this.barButtonServicii.Id = 5;
            this.barButtonServicii.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonServicii.ImageOptions.Image")));
            this.barButtonServicii.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonServicii.ImageOptions.LargeImage")));
            this.barButtonServicii.Name = "barButtonServicii";
            this.barButtonServicii.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonServicii_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Programari";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Clinica";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnPacienti);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnMedici);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Liste";
            // 
            // Nomenclaturi
            // 
            this.Nomenclaturi.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.Nomenclaturi.Name = "Nomenclaturi";
            this.Nomenclaturi.Text = "Nomenclaturi";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnSpecialitati);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonDiagnostice);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonServicii);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Nomenclaturi";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Programari";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Clinica medicala";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barBtnPacienti;
        private DevExpress.XtraBars.BarButtonItem barBtnMedici;
        private DevExpress.XtraBars.BarButtonItem barBtnSpecialitati;
        private DevExpress.XtraBars.Ribbon.RibbonPage Nomenclaturi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonDiagnostice;
        private DevExpress.XtraBars.BarButtonItem barButtonServicii;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}

