namespace CloudApp
{
    partial class usr_form
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ucret = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.pcr_ikon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_ikon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ucret
            // 
            this.lbl_ucret.AutoSize = true;
            this.lbl_ucret.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ucret.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_ucret.Location = new System.Drawing.Point(114, 55);
            this.lbl_ucret.Name = "lbl_ucret";
            this.lbl_ucret.Size = new System.Drawing.Size(66, 15);
            this.lbl_ucret.TabIndex = 11;
            this.lbl_ucret.Text = "ÜCRETSİZ";
            this.lbl_ucret.Click += new System.EventHandler(this.usr_form_Click);
            // 
            // lbl_ad
            // 
            this.lbl_ad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ad.Location = new System.Drawing.Point(64, 18);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(116, 23);
            this.lbl_ad.TabIndex = 10;
            this.lbl_ad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ad.Click += new System.EventHandler(this.usr_form_Click);
            // 
            // pcr_ikon
            // 
            this.pcr_ikon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_ikon.Image = global::CloudApp.Properties.Resources._1417845417_Laptop_48;
            this.pcr_ikon.Location = new System.Drawing.Point(2, 2);
            this.pcr_ikon.Name = "pcr_ikon";
            this.pcr_ikon.Size = new System.Drawing.Size(56, 68);
            this.pcr_ikon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcr_ikon.TabIndex = 9;
            this.pcr_ikon.TabStop = false;
            this.pcr_ikon.Click += new System.EventHandler(this.usr_form_Click);
            // 
            // usr_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_ucret);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.pcr_ikon);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "usr_form";
            this.Size = new System.Drawing.Size(182, 72);
            this.Click += new System.EventHandler(this.usr_form_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pcr_ikon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ucret;
        public System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.PictureBox pcr_ikon;

    }
}
