namespace ADV1.PL
{
    partial class ACHAT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACHAT));
            this.panel_client = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.achatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDVDataSet2 = new ADV1.ADVDataSet2();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colachat_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colachat_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colachat_cat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colachat_four = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colachat_det = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colachat_buy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colachat_sell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colachat_qt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.achatTableAdapter = new ADV1.ADVDataSet2TableAdapters.achatTableAdapter();
            this.panel_client.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDVDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_client
            // 
            this.panel_client.Controls.Add(this.panel1);
            this.panel_client.Controls.Add(this.gridControl1);
            this.panel_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_client.Location = new System.Drawing.Point(0, 0);
            this.panel_client.Name = "panel_client";
            this.panel_client.Size = new System.Drawing.Size(1044, 696);
            this.panel_client.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.simpleButton5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 630);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 66);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(984, 26);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(38, 37);
            this.simpleButton5.TabIndex = 5;
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(799, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 33);
            this.textBox1.TabIndex = 4;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(597, 6);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(196, 57);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "Refrech";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(201, 6);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(196, 57);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Modifier";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(399, 6);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(196, 57);
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
            this.btn_add.Location = new System.Drawing.Point(3, 6);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(196, 57);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Ajoute";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.achatBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1044, 696);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // achatBindingSource
            // 
            this.achatBindingSource.DataMember = "achat";
            this.achatBindingSource.DataSource = this.aDVDataSet2;
            // 
            // aDVDataSet2
            // 
            this.aDVDataSet2.DataSetName = "ADVDataSet2";
            this.aDVDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colachat_name,
            this.colachat_type,
            this.colachat_cat,
            this.colachat_four,
            this.colachat_det,
            this.colachat_buy,
            this.colachat_sell,
            this.colachat_qt});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
            // 
            // colachat_name
            // 
            this.colachat_name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.colachat_name.AppearanceCell.Options.UseFont = true;
            this.colachat_name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colachat_name.AppearanceHeader.Options.UseFont = true;
            this.colachat_name.Caption = "Nome";
            this.colachat_name.FieldName = "achat_name";
            this.colachat_name.Name = "colachat_name";
            this.colachat_name.Visible = true;
            this.colachat_name.VisibleIndex = 0;
            // 
            // colachat_type
            // 
            this.colachat_type.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.colachat_type.AppearanceCell.Options.UseFont = true;
            this.colachat_type.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colachat_type.AppearanceHeader.Options.UseFont = true;
            this.colachat_type.Caption = "Type";
            this.colachat_type.FieldName = "achat_type";
            this.colachat_type.Name = "colachat_type";
            this.colachat_type.Visible = true;
            this.colachat_type.VisibleIndex = 1;
            // 
            // colachat_cat
            // 
            this.colachat_cat.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.colachat_cat.AppearanceCell.Options.UseFont = true;
            this.colachat_cat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colachat_cat.AppearanceHeader.Options.UseFont = true;
            this.colachat_cat.Caption = "Catégorie";
            this.colachat_cat.FieldName = "achat_cat";
            this.colachat_cat.Name = "colachat_cat";
            this.colachat_cat.Visible = true;
            this.colachat_cat.VisibleIndex = 2;
            // 
            // colachat_four
            // 
            this.colachat_four.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.colachat_four.AppearanceCell.Options.UseFont = true;
            this.colachat_four.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colachat_four.AppearanceHeader.Options.UseFont = true;
            this.colachat_four.Caption = "Fournisseur";
            this.colachat_four.FieldName = "achat_four";
            this.colachat_four.Name = "colachat_four";
            this.colachat_four.Visible = true;
            this.colachat_four.VisibleIndex = 3;
            // 
            // colachat_det
            // 
            this.colachat_det.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.colachat_det.AppearanceCell.Options.UseFont = true;
            this.colachat_det.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colachat_det.AppearanceHeader.Options.UseFont = true;
            this.colachat_det.Caption = "Des détails";
            this.colachat_det.FieldName = "achat_det";
            this.colachat_det.Name = "colachat_det";
            this.colachat_det.Visible = true;
            this.colachat_det.VisibleIndex = 4;
            // 
            // colachat_buy
            // 
            this.colachat_buy.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.colachat_buy.AppearanceCell.Options.UseFont = true;
            this.colachat_buy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colachat_buy.AppearanceHeader.Options.UseFont = true;
            this.colachat_buy.Caption = "Prix achat";
            this.colachat_buy.FieldName = "achat_buy";
            this.colachat_buy.Name = "colachat_buy";
            this.colachat_buy.Visible = true;
            this.colachat_buy.VisibleIndex = 5;
            // 
            // colachat_sell
            // 
            this.colachat_sell.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.colachat_sell.AppearanceCell.Options.UseFont = true;
            this.colachat_sell.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colachat_sell.AppearanceHeader.Options.UseFont = true;
            this.colachat_sell.Caption = "Prix vente";
            this.colachat_sell.FieldName = "achat_sell";
            this.colachat_sell.Name = "colachat_sell";
            this.colachat_sell.Visible = true;
            this.colachat_sell.VisibleIndex = 6;
            // 
            // colachat_qt
            // 
            this.colachat_qt.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.colachat_qt.AppearanceCell.Options.UseFont = true;
            this.colachat_qt.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colachat_qt.AppearanceHeader.Options.UseFont = true;
            this.colachat_qt.Caption = "Quantité";
            this.colachat_qt.FieldName = "achat_qt";
            this.colachat_qt.Name = "colachat_qt";
            this.colachat_qt.Visible = true;
            this.colachat_qt.VisibleIndex = 7;
            // 
            // achatTableAdapter
            // 
            this.achatTableAdapter.ClearBeforeFill = true;
            // 
            // ACHAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 696);
            this.Controls.Add(this.panel_client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ACHAT";
            this.Text = "CLIENT";
            this.Load += new System.EventHandler(this.ACHAT_Load);
            this.panel_client.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDVDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_client;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ADVDataSet2 aDVDataSet2;
        private System.Windows.Forms.BindingSource achatBindingSource;
        private ADVDataSet2TableAdapters.achatTableAdapter achatTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colachat_name;
        private DevExpress.XtraGrid.Columns.GridColumn colachat_type;
        private DevExpress.XtraGrid.Columns.GridColumn colachat_cat;
        private DevExpress.XtraGrid.Columns.GridColumn colachat_four;
        private DevExpress.XtraGrid.Columns.GridColumn colachat_det;
        private DevExpress.XtraGrid.Columns.GridColumn colachat_buy;
        private DevExpress.XtraGrid.Columns.GridColumn colachat_sell;
        private DevExpress.XtraGrid.Columns.GridColumn colachat_qt;
        public DevExpress.XtraGrid.GridControl gridControl1;
    }
}