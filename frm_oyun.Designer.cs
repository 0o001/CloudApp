namespace CloudApp
{
    partial class frm_oyun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_oyun));
            this.asf_oyun = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.asf_oyun)).BeginInit();
            this.SuspendLayout();
            // 
            // asf_oyun
            // 
            this.asf_oyun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.asf_oyun.Enabled = true;
            this.asf_oyun.Location = new System.Drawing.Point(0, 0);
            this.asf_oyun.Name = "asf_oyun";
            this.asf_oyun.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("asf_oyun.OcxState")));
            this.asf_oyun.Size = new System.Drawing.Size(642, 394);
            this.asf_oyun.TabIndex = 0;
            // 
            // frm_oyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 394);
            this.Controls.Add(this.asf_oyun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_oyun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.asf_oyun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public AxShockwaveFlashObjects.AxShockwaveFlash asf_oyun;



    }
}