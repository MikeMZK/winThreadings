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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.lblStoppuhr = new System.Windows.Forms.Label();
            this.timerT = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 215);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Location = new System.Drawing.Point(240, 215);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(85, 34);
            this.btnBeenden.TabIndex = 1;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // lblStoppuhr
            // 
            this.lblStoppuhr.AutoSize = true;
            this.lblStoppuhr.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoppuhr.Location = new System.Drawing.Point(-4, 75);
            this.lblStoppuhr.Name = "lblStoppuhr";
            this.lblStoppuhr.Size = new System.Drawing.Size(347, 91);
            this.lblStoppuhr.TabIndex = 2;
            this.lblStoppuhr.Text = "00:00:00";
            // 
            // timerT
            // 
            this.timerT.Tick += new System.EventHandler(this.timerT_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 261);
            this.Controls.Add(this.lblStoppuhr);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnStart);
            this.Name = "frmMain";
            this.Text = "Stoppuhr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Label lblStoppuhr;
        private System.Windows.Forms.Timer timerT;
    }
}

