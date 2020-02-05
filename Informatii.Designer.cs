namespace ClinicaMed
{
    partial class Informatii
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txPrenume = new DevExpress.XtraEditors.TextEdit();
            this.txNume = new System.Windows.Forms.TextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Nume = new DevExpress.XtraLayout.LayoutControlItem();
            this.Prenume = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.txPrenumeM = new DevExpress.XtraEditors.TextEdit();
            this.Vizite = new System.Windows.Forms.Label();
            this.txNumeM = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.NumeMedic = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.PrenumeMedic = new DevExpress.XtraLayout.LayoutControlItem();
            this.Data = new DevExpress.XtraLayout.LayoutControlItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.vizite1 = new ClinicaMed.Vizite();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txPrenume.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prenume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPrenumeM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txNumeM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumeMedic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrenumeMedic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizite1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Controls.Add(this.txPrenume);
            this.layoutControl1.Controls.Add(this.txNume);
            this.layoutControl1.Location = new System.Drawing.Point(30, 96);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(424, 24, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(225, 244);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date Pacient";
            // 
            // txPrenume
            // 
            this.txPrenume.Location = new System.Drawing.Point(47, 51);
            this.txPrenume.Margin = new System.Windows.Forms.Padding(2);
            this.txPrenume.Name = "txPrenume";
            this.txPrenume.Size = new System.Drawing.Size(176, 20);
            this.txPrenume.StyleController = this.layoutControl1;
            this.txPrenume.TabIndex = 5;
            this.txPrenume.EditValueChanged += new System.EventHandler(this.txPrenume_EditValueChanged);
            // 
            // txNume
            // 
            this.txNume.Location = new System.Drawing.Point(47, 27);
            this.txNume.Margin = new System.Windows.Forms.Padding(2);
            this.txNume.Name = "txNume";
            this.txNume.Size = new System.Drawing.Size(176, 20);
            this.txNume.TabIndex = 4;
            this.txNume.TextChanged += new System.EventHandler(this.txNume_TextChanged);
            // 
            // Root
            // 
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Nume,
            this.Prenume,
            this.emptySpaceItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.Root.Size = new System.Drawing.Size(225, 244);
            this.Root.TextVisible = false;
            // 
            // Nume
            // 
            this.Nume.Control = this.txNume;
            this.Nume.CustomizationFormText = "Nume";
            this.Nume.Location = new System.Drawing.Point(0, 25);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(225, 24);
            this.Nume.TextSize = new System.Drawing.Size(42, 13);
            // 
            // Prenume
            // 
            this.Prenume.Control = this.txPrenume;
            this.Prenume.CustomizationFormText = "Prenume";
            this.Prenume.Location = new System.Drawing.Point(0, 49);
            this.Prenume.Name = "Prenume";
            this.Prenume.Size = new System.Drawing.Size(225, 24);
            this.Prenume.TextSize = new System.Drawing.Size(42, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 73);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(225, 171);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.label1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(225, 25);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.dateEdit1);
            this.layoutControl2.Controls.Add(this.txPrenumeM);
            this.layoutControl2.Controls.Add(this.Vizite);
            this.layoutControl2.Controls.Add(this.txNumeM);
            this.layoutControl2.Location = new System.Drawing.Point(318, 93);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1049, 4, 812, 500);
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(248, 245);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(74, 86);
            this.dateEdit1.Margin = new System.Windows.Forms.Padding(2);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(172, 20);
            this.dateEdit1.StyleController = this.layoutControl2;
            this.dateEdit1.TabIndex = 8;
            this.dateEdit1.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
            // 
            // txPrenumeM
            // 
            this.txPrenumeM.Location = new System.Drawing.Point(74, 62);
            this.txPrenumeM.Margin = new System.Windows.Forms.Padding(2);
            this.txPrenumeM.Name = "txPrenumeM";
            this.txPrenumeM.Size = new System.Drawing.Size(172, 20);
            this.txPrenumeM.StyleController = this.layoutControl2;
            this.txPrenumeM.TabIndex = 7;
            this.txPrenumeM.EditValueChanged += new System.EventHandler(this.txPrenumeM_EditValueChanged);
            // 
            // Vizite
            // 
            this.Vizite.Location = new System.Drawing.Point(2, 2);
            this.Vizite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Vizite.Name = "Vizite";
            this.Vizite.Size = new System.Drawing.Size(244, 32);
            this.Vizite.TabIndex = 6;
            this.Vizite.Text = "Vizite medicale";
            // 
            // txNumeM
            // 
            this.txNumeM.Location = new System.Drawing.Point(74, 38);
            this.txNumeM.Margin = new System.Windows.Forms.Padding(2);
            this.txNumeM.Name = "txNumeM";
            this.txNumeM.Size = new System.Drawing.Size(172, 20);
            this.txNumeM.StyleController = this.layoutControl2;
            this.txNumeM.TabIndex = 4;
            this.txNumeM.EditValueChanged += new System.EventHandler(this.txNumeM_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.NumeMedic,
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.PrenumeMedic,
            this.Data});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(248, 245);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // NumeMedic
            // 
            this.NumeMedic.Control = this.txNumeM;
            this.NumeMedic.Location = new System.Drawing.Point(0, 36);
            this.NumeMedic.Name = "NumeMedic";
            this.NumeMedic.Size = new System.Drawing.Size(248, 24);
            this.NumeMedic.TextSize = new System.Drawing.Size(69, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 108);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(248, 137);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Vizite;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(248, 36);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // PrenumeMedic
            // 
            this.PrenumeMedic.Control = this.txPrenumeM;
            this.PrenumeMedic.Location = new System.Drawing.Point(0, 60);
            this.PrenumeMedic.Name = "PrenumeMedic";
            this.PrenumeMedic.Size = new System.Drawing.Size(248, 24);
            this.PrenumeMedic.TextSize = new System.Drawing.Size(69, 13);
            // 
            // Data
            // 
            this.Data.Control = this.dateEdit1;
            this.Data.CustomizationFormText = "Data";
            this.Data.Location = new System.Drawing.Point(0, 84);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(248, 24);
            this.Data.TextSize = new System.Drawing.Size(69, 13);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Californian FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informatii pacient";
            // 
            // vizite1
            // 
            this.vizite1.DataSetName = "Vizite";
            this.vizite1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Informatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Informatii";
            this.Text = "Informatii";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txPrenume.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prenume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPrenumeM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txNumeM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumeMedic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrenumeMedic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizite1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.TextBox txNume;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem Nume;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private Vizite vizite1;
        private DevExpress.XtraEditors.TextEdit txPrenume;
        private DevExpress.XtraLayout.LayoutControlItem Prenume;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private System.Windows.Forms.Label Vizite;
        private DevExpress.XtraEditors.TextEdit txNumeM;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem NumeMedic;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txPrenumeM;
        private DevExpress.XtraLayout.LayoutControlItem PrenumeMedic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControlItem Data;
        private System.Windows.Forms.Label label2;
    }
}