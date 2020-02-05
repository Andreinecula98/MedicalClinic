namespace ClinicaMed
{
    partial class Medici
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medici));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vizite = new ClinicaMed.Vizite();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_medic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_utiliz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_specializare = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.specialitatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomDs = new ClinicaMed.Nom();
            this.colID_vizita = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrenume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mediciTableAdapter = new ClinicaMed.ViziteTableAdapters.MediciTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.specialitatiTableAdapter = new ClinicaMed.NomTableAdapters.SpecialitatiTableAdapter();
            this.pacientiTableAdapter = new ClinicaMed.ViziteTableAdapters.PacientiTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 61);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(800, 365);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Medici";
            this.bindingSource1.DataSource = this.vizite;
            // 
            // vizite
            // 
            this.vizite.DataSetName = "Vizite";
            this.vizite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_medic,
            this.colID_utiliz,
            this.colID_specializare,
            this.colID_vizita,
            this.colNume,
            this.colPrenume});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(547, 358, 322, 276);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colID_medic
            // 
            this.colID_medic.FieldName = "ID_medic";
            this.colID_medic.MinWidth = 25;
            this.colID_medic.Name = "colID_medic";
            this.colID_medic.OptionsColumn.ReadOnly = true;
            this.colID_medic.Width = 94;
            // 
            // colID_utiliz
            // 
            this.colID_utiliz.FieldName = "ID_utiliz";
            this.colID_utiliz.MinWidth = 25;
            this.colID_utiliz.Name = "colID_utiliz";
            this.colID_utiliz.Width = 94;
            // 
            // colID_specializare
            // 
            this.colID_specializare.Caption = "Specialitate";
            this.colID_specializare.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colID_specializare.FieldName = "ID_specializare";
            this.colID_specializare.MinWidth = 25;
            this.colID_specializare.Name = "colID_specializare";
            this.colID_specializare.Visible = true;
            this.colID_specializare.VisibleIndex = 2;
            this.colID_specializare.Width = 94;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.specialitatiBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Nume";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ID_specializare";
            // 
            // specialitatiBindingSource
            // 
            this.specialitatiBindingSource.DataMember = "Specialitati";
            this.specialitatiBindingSource.DataSource = this.nomDs;
            // 
            // nomDs
            // 
            this.nomDs.DataSetName = "Nom";
            this.nomDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colID_vizita
            // 
            this.colID_vizita.FieldName = "ID_vizita";
            this.colID_vizita.MinWidth = 25;
            this.colID_vizita.Name = "colID_vizita";
            this.colID_vizita.Width = 94;
            // 
            // colNume
            // 
            this.colNume.FieldName = "Nume";
            this.colNume.MinWidth = 25;
            this.colNume.Name = "colNume";
            this.colNume.Visible = true;
            this.colNume.VisibleIndex = 1;
            this.colNume.Width = 94;
            // 
            // colPrenume
            // 
            this.colPrenume.FieldName = "Prenume";
            this.colPrenume.MinWidth = 25;
            this.colPrenume.Name = "colPrenume";
            this.colPrenume.Visible = true;
            this.colPrenume.VisibleIndex = 0;
            this.colPrenume.Width = 94;
            // 
            // mediciTableAdapter
            // 
            this.mediciTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barStaticItem1,
            this.barButtonItem2,
            this.barStaticItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Salveaza";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem1_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Salveaza";
            this.barStaticItem1.Id = 1;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 61);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 426);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 365);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 61);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 365);
            // 
            // specialitatiTableAdapter
            // 
            this.specialitatiTableAdapter.ClearBeforeFill = true;
            // 
            // pacientiTableAdapter
            // 
            this.pacientiTableAdapter.ClearBeforeFill = true;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Informatii Pacient";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
         //   this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem2_ItemClick);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Informatii pacient";
            this.barStaticItem2.Id = 3;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // Medici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Medici";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Medici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Vizite vizite;
        private ViziteTableAdapters.MediciTableAdapter mediciTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn colID_medic;
        private DevExpress.XtraGrid.Columns.GridColumn colID_utiliz;
        private DevExpress.XtraGrid.Columns.GridColumn colID_specializare;
        private DevExpress.XtraGrid.Columns.GridColumn colID_vizita;
        private DevExpress.XtraGrid.Columns.GridColumn colNume;
        private DevExpress.XtraGrid.Columns.GridColumn colPrenume;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private Nom nomDs;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource specialitatiBindingSource;
        private NomTableAdapters.SpecialitatiTableAdapter specialitatiTableAdapter;
        private ViziteTableAdapters.PacientiTableAdapter pacientiTableAdapter;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
    }
}