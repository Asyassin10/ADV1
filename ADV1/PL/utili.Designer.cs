namespace ADV1.PL
{
    partial class Utili
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Utili));
            this.panel_utili = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.utiliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDVDataSet5 = new ADV1.ADVDataSet5();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colutili_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colutili_pass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colutili_roll = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colutili_state = new DevExpress.XtraGrid.Columns.GridColumn();
            this.utiliTableAdapter = new ADV1.ADVDataSet5TableAdapters.utiliTableAdapter();
            this.panel_utili.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utiliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDVDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_utili
            // 
            this.panel_utili.Controls.Add(this.panel1);
            this.panel_utili.Controls.Add(this.gridControl1);
            this.panel_utili.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_utili.Location = new System.Drawing.Point(0, 0);
            this.panel_utili.Name = "panel_utili";
            this.panel_utili.Size = new System.Drawing.Size(1044, 696);
            this.panel_utili.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.simpleButton5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 630);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 66);
            this.panel1.TabIndex = 6;
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
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(3, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(196, 57);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Ajoute";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.utiliBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1044, 696);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // utiliBindingSource
            // 
            this.utiliBindingSource.DataMember = "utili";
            this.utiliBindingSource.DataSource = this.aDVDataSet5;
            // 
            // aDVDataSet5
            // 
            this.aDVDataSet5.DataSetName = "ADVDataSet5";
            this.aDVDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colutili_user,
            this.colutili_pass,
            this.colutili_roll,
            this.colutili_state});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colutili_user
            // 
            this.colutili_user.FieldName = "utili_user";
            this.colutili_user.Name = "colutili_user";
            this.colutili_user.Visible = true;
            this.colutili_user.VisibleIndex = 0;
            // 
            // colutili_pass
            // 
            this.colutili_pass.FieldName = "utili_pass";
            this.colutili_pass.Name = "colutili_pass";
            this.colutili_pass.Visible = true;
            this.colutili_pass.VisibleIndex = 1;
            // 
            // colutili_roll
            // 
            this.colutili_roll.FieldName = "utili_roll";
            this.colutili_roll.Name = "colutili_roll";
            this.colutili_roll.Visible = true;
            this.colutili_roll.VisibleIndex = 2;
            // 
            // colutili_state
            // 
            this.colutili_state.FieldName = "utili_state";
            this.colutili_state.Name = "colutili_state";
            this.colutili_state.Visible = true;
            this.colutili_state.VisibleIndex = 3;
            // 
            // utiliTableAdapter
            // 
            this.utiliTableAdapter.ClearBeforeFill = true;
            // 
            // Utili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 696);
            this.Controls.Add(this.panel_utili);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Utili";
            this.ShowInTaskbar = false;
            this.Text = "utili";
            this.Load += new System.EventHandler(this.utili_Load);
            this.panel_utili.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utiliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDVDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_utili;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ADVDataSet5 aDVDataSet5;
        private System.Windows.Forms.BindingSource utiliBindingSource;
        private ADVDataSet5TableAdapters.utiliTableAdapter utiliTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colutili_user;
        private DevExpress.XtraGrid.Columns.GridColumn colutili_pass;
        private DevExpress.XtraGrid.Columns.GridColumn colutili_roll;
        private DevExpress.XtraGrid.Columns.GridColumn colutili_state;
        public DevExpress.XtraGrid.GridControl gridControl1;
    }
}