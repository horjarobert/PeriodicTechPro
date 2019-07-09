namespace PeriodicTechPro
{
    partial class esketitNr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(esketitNr));
            this.text = new System.Windows.Forms.Label();
            this.eske = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barr = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.White;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(12, 104);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(513, 249);
            this.text.TabIndex = 0;
            this.text.Text = resources.GetString("text.Text");
            // 
            // eske
            // 
            this.eske.BackColor = System.Drawing.Color.White;
            this.eske.Font = new System.Drawing.Font("Noto Kufi Arabic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eske.Location = new System.Drawing.Point(146, 29);
            this.eske.Name = "eske";
            this.eske.Size = new System.Drawing.Size(245, 53);
            this.eske.TabIndex = 1;
            this.eske.Text = "Esketit number";
            this.eske.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.White;
            this.close.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Noto Kufi Arabic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(477, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(44, 39);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.barr);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 372);
            this.panel1.TabIndex = 3;
            // 
            // barr
            // 
            this.barr.BackColor = System.Drawing.Color.Black;
            this.barr.Location = new System.Drawing.Point(13, 80);
            this.barr.Name = "barr";
            this.barr.Size = new System.Drawing.Size(506, 3);
            this.barr.TabIndex = 0;
            this.barr.Text = "label1";
            // 
            // esketitNr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(537, 376);
            this.Controls.Add(this.close);
            this.Controls.Add(this.eske);
            this.Controls.Add(this.text);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "esketitNr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About \'esketit number\'";
            this.Load += new System.EventHandler(this.esketitNr_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label eske;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label barr;
    }
}