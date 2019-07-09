namespace PeriodicTechPro
{
    partial class webDev
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.forWho = new System.Windows.Forms.Label();
            this.good = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.forWho);
            this.panel1.Controls.Add(this.good);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 215);
            this.panel1.TabIndex = 3;
            // 
            // forWho
            // 
            this.forWho.BackColor = System.Drawing.Color.Turquoise;
            this.forWho.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forWho.ForeColor = System.Drawing.SystemColors.ControlText;
            this.forWho.Location = new System.Drawing.Point(100, 104);
            this.forWho.Name = "forWho";
            this.forWho.Size = new System.Drawing.Size(502, 80);
            this.forWho.TabIndex = 1;
            this.forWho.Text = "Web developers";
            this.forWho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // good
            // 
            this.good.BackColor = System.Drawing.Color.Turquoise;
            this.good.Font = new System.Drawing.Font("Reem Kufi Regular", 36F, System.Drawing.FontStyle.Bold);
            this.good.ForeColor = System.Drawing.SystemColors.ControlText;
            this.good.Location = new System.Drawing.Point(124, 16);
            this.good.Name = "good";
            this.good.Size = new System.Drawing.Size(461, 80);
            this.good.TabIndex = 0;
            this.good.Text = "Good practice for:";
            this.good.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // webDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 238);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "webDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "webDev";
            this.Load += new System.EventHandler(this.webDev_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label forWho;
        private System.Windows.Forms.Label good;
    }
}