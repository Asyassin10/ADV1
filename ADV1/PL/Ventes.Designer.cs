namespace ADV1.PL
{
    partial class Ventes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventes));
            this.panel_ventes = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.venteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDVDataSet4 = new ADV1.ADVDataSet4();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colvent_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvent_cli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvent_prix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvent_qt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvent_Tprix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvent_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.venteTableAdapter = new ADV1.ADVDataSet4TableAdapters.venteTableAdapter();
            this.panel_ventes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDVDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ventes
            // 
            this.panel_ventes.Controls.Add(this.panel1);
            this.panel_ventes.Controls.Add(this.gridControl1);
            this.panel_ventes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ventes.Location = new System.Drawing.Point(0, 0);
            this.panel_ventes.Name = "panel_ventes";
            this.panel_ventes.Size = new System.Drawing.Size(1044, 696);
            this.panel_ventes.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.simpleButton5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 630);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 66);
            this.panel1.TabIndex = 6;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(1005, 26);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(36, 36);
            this.simpleButton5.TabIndex = 5;
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(871, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 33);
            this.textBox1.TabIndex = 4;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(629, 6);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(235, 57);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "Refrech";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(316, 5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(235, 57);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Supprimer";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn_add
            // 
            this.btn_add.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(3, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(235, 57);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Ajoute";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.venteBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1044, 696);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // venteBindingSource
            // 
            this.venteBindingSource.DataMember = "vente";
            this.venteBindingSource.DataSource = this.aDVDataSet4;
            // 
            // aDVDataSet4
            // 
            this.aDVDataSet4.DataSetName = "ADVDataSet4";
            this.aDVDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colvent_name,
            this.colvent_cli,
            this.colvent_prix,
            this.colvent_qt,
            this.colvent_Tprix,
            this.colvent_date});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colvent_name
            // 
            this.colvent_name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colvent_name.AppearanceHeader.Options.UseFont = true;
            this.colvent_name.Caption = "Nome";
            this.colvent_name.FieldName = "vent_name";
            this.colvent_name.Name = "colvent_name";
            this.colvent_name.Visible = true;
            this.colvent_name.VisibleIndex = 0;
            // 
            // colvent_cli
            // 
            this.colvent_cli.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colvent_cli.AppearanceHeader.Options.UseFont = true;
            this.colvent_cli.Caption = "Cliente";
            this.colvent_cli.FieldName = "vent_cli";
            this.colvent_cli.Name = "colvent_cli";
            this.colvent_cli.Visible = true;
            this.colvent_cli.VisibleIndex = 1;
            // 
            // colvent_prix
            // 
            this.colvent_prix.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colvent_prix.AppearanceHeader.Options.UseFont = true;
            this.colvent_prix.Caption = "Prix";
            this.colvent_prix.FieldName = "vent_prix";
            this.colvent_prix.Name = "colvent_prix";
            this.colvent_prix.Visible = true;
            this.colvent_prix.VisibleIndex = 2;
            // 
            // colvent_qt
            // 
            this.colvent_qt.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colvent_qt.AppearanceHeader.Options.UseFont = true;
            this.colvent_qt.Caption = "Quantité";
            this.colvent_qt.FieldName = "vent_qt";
            this.colvent_qt.Name = "colvent_qt";
            this.colvent_qt.Visible = true;
            this.colvent_qt.VisibleIndex = 3;
            // 
            // colvent_Tprix
            // 
            this.colvent_Tprix.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colvent_Tprix.AppearanceHeader.Options.UseFont = true;
            this.colvent_Tprix.Caption = "Prix Total";
            this.colvent_Tprix.FieldName = "vent_Tprix";
            this.colvent_Tprix.Name = "colvent_Tprix";
            this.colvent_Tprix.Visible = true;
            this.colvent_Tprix.VisibleIndex = 4;
            // 
            // colvent_date
            // 
            this.colvent_date.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colvent_date.AppearanceHeader.Options.UseFont = true;
            this.colvent_date.Caption = "Date";
            this.colvent_date.FieldName = "vent_date";
            this.colvent_date.Name = "colvent_date";
            this.colvent_date.Visible = true;
            this.colvent_date.VisibleIndex = 5;
            // 
            // venteTableAdapter
            // 
            this.venteTableAdapter.ClearBeforeFill = true;
            // 
            // Ventes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 696);
            this.Controls.Add(this.panel_ventes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventes";
            this.Text = "Ventes";
            this.Load += new System.EventHandler(this.Ventes_Load);
            this.panel_ventes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDVDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_ventes;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ADVDataSet4 aDVDataSet4;
        private System.Windows.Forms.BindingSource venteBindingSource;
        private ADVDataSet4TableAdapters.venteTableAdapter venteTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colvent_name;
        private DevExpress.XtraGrid.Columns.GridColumn colvent_cli;
        private DevExpress.XtraGrid.Columns.GridColumn colvent_prix;
        private DevExpress.XtraGrid.Columns.GridColumn colvent_qt;
        private DevExpress.XtraGrid.Columns.GridColumn colvent_Tprix;
        private DevExpress.XtraGrid.Columns.GridColumn colvent_date;
        public DevExpress.XtraGrid.GridControl gridControl1;
    }
}