namespace Messaggistica
{
    partial class FrmElimina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmElimina));
            this.btnMe = new System.Windows.Forms.Button();
            this.btnTutti = new System.Windows.Forms.Button();
            this.lblDomanda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMe
            // 
            this.btnMe.ForeColor = System.Drawing.Color.Black;
            this.btnMe.Location = new System.Drawing.Point(28, 90);
            this.btnMe.Name = "btnMe";
            this.btnMe.Size = new System.Drawing.Size(75, 23);
            this.btnMe.TabIndex = 0;
            this.btnMe.Text = "Per me";
            this.btnMe.UseVisualStyleBackColor = true;
            this.btnMe.Click += new System.EventHandler(this.btnMe_Click);
            // 
            // btnTutti
            // 
            this.btnTutti.ForeColor = System.Drawing.Color.Black;
            this.btnTutti.Location = new System.Drawing.Point(119, 90);
            this.btnTutti.Name = "btnTutti";
            this.btnTutti.Size = new System.Drawing.Size(75, 23);
            this.btnTutti.TabIndex = 1;
            this.btnTutti.Text = "Per tutti";
            this.btnTutti.UseVisualStyleBackColor = true;
            this.btnTutti.Click += new System.EventHandler(this.btnTutti_Click);
            // 
            // lblDomanda
            // 
            this.lblDomanda.AutoSize = true;
            this.lblDomanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomanda.Location = new System.Drawing.Point(12, 37);
            this.lblDomanda.Name = "lblDomanda";
            this.lblDomanda.Size = new System.Drawing.Size(208, 20);
            this.lblDomanda.TabIndex = 2;
            this.lblDomanda.Text = "Vuoi eliminare il messaggio?";
            // 
            // FrmElimina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(226, 125);
            this.Controls.Add(this.lblDomanda);
            this.Controls.Add(this.btnTutti);
            this.Controls.Add(this.btnMe);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmElimina";
            this.Text = "Elimina";
            this.Load += new System.EventHandler(this.Elimina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMe;
        private System.Windows.Forms.Button btnTutti;
        private System.Windows.Forms.Label lblDomanda;
    }
}