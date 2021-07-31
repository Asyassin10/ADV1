namespace ADV1.EBL
{
    partial class dailog
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
            this.dailog_txt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // dailog_txt
            // 
            this.dailog_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailog_txt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dailog_txt.Location = new System.Drawing.Point(23, 7);
            this.dailog_txt.Name = "dailog_txt";
            this.dailog_txt.Size = new System.Drawing.Size(680, 147);
            this.dailog_txt.TabIndex = 0;
            this.dailog_txt.Text = "label1";
            this.dailog_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dailog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 163);
            this.Controls.Add(this.dailog_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dailog";
            this.ShowInTaskbar = false;
            this.Text = "dailog";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label dailog_txt;
        private System.Windows.Forms.Timer timer1;
    }
}