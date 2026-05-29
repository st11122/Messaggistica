namespace Messaggistica
{
    partial class FrmAggiungi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAggiungi));
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIDcontatto = new System.Windows.Forms.Label();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.nudIDcontatto = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudIDcontatto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNickname
            // 
            this.tbNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNickname.Location = new System.Drawing.Point(199, 12);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(157, 29);
            this.tbNickname.TabIndex = 13;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNome.Location = new System.Drawing.Point(12, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 24);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome";
            // 
            // lblIDcontatto
            // 
            this.lblIDcontatto.AutoSize = true;
            this.lblIDcontatto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDcontatto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIDcontatto.Location = new System.Drawing.Point(12, 54);
            this.lblIDcontatto.Name = "lblIDcontatto";
            this.lblIDcontatto.Size = new System.Drawing.Size(27, 24);
            this.lblIDcontatto.TabIndex = 11;
            this.lblIDcontatto.Text = "ID";
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(12, 99);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(157, 36);
            this.btnAnnulla.TabIndex = 10;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.Location = new System.Drawing.Point(199, 99);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(157, 36);
            this.btnAggiungi.TabIndex = 9;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // nudIDcontatto
            // 
            this.nudIDcontatto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIDcontatto.Location = new System.Drawing.Point(199, 58);
            this.nudIDcontatto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudIDcontatto.Name = "nudIDcontatto";
            this.nudIDcontatto.Size = new System.Drawing.Size(157, 29);
            this.nudIDcontatto.TabIndex = 14;
            // 
            // FrmAggiungi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(373, 147);
            this.Controls.Add(this.nudIDcontatto);
            this.Controls.Add(this.tbNickname);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblIDcontatto);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnAggiungi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAggiungi";
            this.Text = "Aggiungi";
            ((System.ComponentModel.ISupportInitialize)(this.nudIDcontatto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIDcontatto;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.NumericUpDown nudIDcontatto;
    }
}