namespace winThreadings
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRot = new System.Windows.Forms.Button();
            this.btnBlau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRot
            // 
            this.btnRot.BackColor = System.Drawing.Color.Red;
            this.btnRot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRot.Location = new System.Drawing.Point(12, 12);
            this.btnRot.Name = "btnRot";
            this.btnRot.Size = new System.Drawing.Size(110, 63);
            this.btnRot.TabIndex = 0;
            this.btnRot.Text = "Rot";
            this.btnRot.UseVisualStyleBackColor = false;
            this.btnRot.Click += new System.EventHandler(this.btnRot_Click);
            // 
            // btnBlau
            // 
            this.btnBlau.BackColor = System.Drawing.Color.Blue;
            this.btnBlau.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlau.Location = new System.Drawing.Point(963, 12);
            this.btnBlau.Name = "btnBlau";
            this.btnBlau.Size = new System.Drawing.Size(102, 63);
            this.btnBlau.TabIndex = 1;
            this.btnBlau.Text = "Blau";
            this.btnBlau.UseVisualStyleBackColor = false;
            this.btnBlau.Click += new System.EventHandler(this.btnBlau_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 512);
            this.Controls.Add(this.btnBlau);
            this.Controls.Add(this.btnRot);
            this.Name = "frmMain";
            this.Text = "Threading";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRot;
        private System.Windows.Forms.Button btnBlau;
    }
}

