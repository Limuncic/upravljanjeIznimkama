namespace upravljanjeIznimkama
{
    partial class Form1
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
            this.txtUnos = new System.Windows.Forms.TextBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btKlikni = new System.Windows.Forms.Button();
            this.lblIspis = new System.Windows.Forms.Label();
            this.lblUnesi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUnos
            // 
            this.txtUnos.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnos.Location = new System.Drawing.Point(228, 278);
            this.txtUnos.Name = "txtUnos";
            this.txtUnos.Size = new System.Drawing.Size(330, 29);
            this.txtUnos.TabIndex = 0;
            // 
            // txtIspis
            // 
            this.txtIspis.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIspis.Location = new System.Drawing.Point(228, 360);
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(330, 33);
            this.txtIspis.TabIndex = 1;
            // 
            // btKlikni
            // 
            this.btKlikni.Font = new System.Drawing.Font("Algerian", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKlikni.Location = new System.Drawing.Point(455, 420);
            this.btKlikni.Name = "btKlikni";
            this.btKlikni.Size = new System.Drawing.Size(113, 45);
            this.btKlikni.TabIndex = 2;
            this.btKlikni.Text = "\"click\"";
            this.btKlikni.UseVisualStyleBackColor = true;
            this.btKlikni.Click += new System.EventHandler(this.btKlikni_Click);
            // 
            // lblIspis
            // 
            this.lblIspis.AutoSize = true;
            this.lblIspis.Font = new System.Drawing.Font("Algerian", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIspis.Location = new System.Drawing.Point(223, 332);
            this.lblIspis.Name = "lblIspis";
            this.lblIspis.Size = new System.Drawing.Size(113, 24);
            this.lblIspis.TabIndex = 3;
            this.lblIspis.Text = "Roden si:";
            // 
            // lblUnesi
            // 
            this.lblUnesi.AutoSize = true;
            this.lblUnesi.Font = new System.Drawing.Font("Algerian", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnesi.Location = new System.Drawing.Point(223, 240);
            this.lblUnesi.Name = "lblUnesi";
            this.lblUnesi.Size = new System.Drawing.Size(337, 24);
            this.lblUnesi.TabIndex = 4;
            this.lblUnesi.Text = "Unesi svoju godinu ređenja:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 638);
            this.Controls.Add(this.lblUnesi);
            this.Controls.Add(this.lblIspis);
            this.Controls.Add(this.btKlikni);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.txtUnos);
            this.Name = "Form1";
            this.Text = "upravljanjeIznimkama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnos;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button btKlikni;
        private System.Windows.Forms.Label lblIspis;
        private System.Windows.Forms.Label lblUnesi;
    }
}

