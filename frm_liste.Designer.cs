namespace CloudApp
{
    partial class frm_liste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_liste));
            this.flp_liste = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_simgeler = new System.Windows.Forms.FlowLayoutPanel();
            this.pcr_konsol = new System.Windows.Forms.PictureBox();
            this.pcr_form = new System.Windows.Forms.PictureBox();
            this.pcr_oyun = new System.Windows.Forms.PictureBox();
            this.flp_simgeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_konsol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_oyun)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_liste
            // 
            this.flp_liste.AutoScroll = true;
            this.flp_liste.BackColor = System.Drawing.Color.White;
            this.flp_liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_liste.Location = new System.Drawing.Point(57, 0);
            this.flp_liste.Name = "flp_liste";
            this.flp_liste.Size = new System.Drawing.Size(663, 383);
            this.flp_liste.TabIndex = 3;
            // 
            // flp_simgeler
            // 
            this.flp_simgeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flp_simgeler.Controls.Add(this.pcr_konsol);
            this.flp_simgeler.Controls.Add(this.pcr_form);
            this.flp_simgeler.Controls.Add(this.pcr_oyun);
            this.flp_simgeler.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp_simgeler.Location = new System.Drawing.Point(0, 0);
            this.flp_simgeler.Name = "flp_simgeler";
            this.flp_simgeler.Size = new System.Drawing.Size(57, 383);
            this.flp_simgeler.TabIndex = 2;
            // 
            // pcr_konsol
            // 
            this.pcr_konsol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_konsol.Image = global::CloudApp.Properties.Resources._1417723983_application_code_48;
            this.pcr_konsol.Location = new System.Drawing.Point(3, 3);
            this.pcr_konsol.Name = "pcr_konsol";
            this.pcr_konsol.Size = new System.Drawing.Size(54, 50);
            this.pcr_konsol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcr_konsol.TabIndex = 1;
            this.pcr_konsol.TabStop = false;
            this.pcr_konsol.Click += new System.EventHandler(this.pcr_uygulama_Click);
            // 
            // pcr_form
            // 
            this.pcr_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_form.Image = global::CloudApp.Properties.Resources._1417845417_Laptop_48;
            this.pcr_form.Location = new System.Drawing.Point(3, 59);
            this.pcr_form.Name = "pcr_form";
            this.pcr_form.Size = new System.Drawing.Size(54, 50);
            this.pcr_form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcr_form.TabIndex = 3;
            this.pcr_form.TabStop = false;
            this.pcr_form.Click += new System.EventHandler(this.pcr_form_Click);
            // 
            // pcr_oyun
            // 
            this.pcr_oyun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_oyun.Image = global::CloudApp.Properties.Resources._1417723887_Controller_48;
            this.pcr_oyun.Location = new System.Drawing.Point(3, 115);
            this.pcr_oyun.Name = "pcr_oyun";
            this.pcr_oyun.Size = new System.Drawing.Size(54, 50);
            this.pcr_oyun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcr_oyun.TabIndex = 2;
            this.pcr_oyun.TabStop = false;
            this.pcr_oyun.Click += new System.EventHandler(this.pcr_oyun_Click);
            // 
            // frm_liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 383);
            this.Controls.Add(this.flp_liste);
            this.Controls.Add(this.flp_simgeler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_liste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CloudApp";
            this.Load += new System.EventHandler(this.frm_liste_Load);
            this.flp_simgeler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcr_konsol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_oyun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcr_konsol;
        private System.Windows.Forms.FlowLayoutPanel flp_liste;
        private System.Windows.Forms.FlowLayoutPanel flp_simgeler;
        private System.Windows.Forms.PictureBox pcr_oyun;
        private System.Windows.Forms.PictureBox pcr_form;
    }
}

