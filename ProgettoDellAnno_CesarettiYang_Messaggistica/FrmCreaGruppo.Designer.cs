namespace Messaggistica
{
    partial class FrmCreaGruppo
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
            this.btnCreaAggiungi = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lvContatti = new System.Windows.Forms.ListView();
            this.chNickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCerca = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbNomeGruppo = new System.Windows.Forms.TextBox();
            this.nudIDcontatto = new System.Windows.Forms.NumericUpDown();
            this.rtbDescrizione = new System.Windows.Forms.RichTextBox();
            this.lblDescrizione = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudIDcontatto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreaAggiungi
            // 
            this.btnCreaAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreaAggiungi.Location = new System.Drawing.Point(199, 434);
            this.btnCreaAggiungi.Name = "btnCreaAggiungi";
            this.btnCreaAggiungi.Size = new System.Drawing.Size(157, 36);
            this.btnCreaAggiungi.TabIndex = 0;
            this.btnCreaAggiungi.Text = "Crea";
            this.btnCreaAggiungi.UseVisualStyleBackColor = true;
            this.btnCreaAggiungi.Click += new System.EventHandler(this.btnCreaAggiungi_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(12, 434);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(157, 36);
            this.btnAnnulla.TabIndex = 1;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblID.Location = new System.Drawing.Point(12, 57);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 24);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lvContatti
            // 
            this.lvContatti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNickname,
            this.chID});
            this.lvContatti.FullRowSelect = true;
            this.lvContatti.HideSelection = false;
            this.lvContatti.Location = new System.Drawing.Point(12, 232);
            this.lvContatti.Name = "lvContatti";
            this.lvContatti.Size = new System.Drawing.Size(344, 179);
            this.lvContatti.TabIndex = 5;
            this.lvContatti.UseCompatibleStateImageBehavior = false;
            this.lvContatti.View = System.Windows.Forms.View.Details;
            // 
            // chNickname
            // 
            this.chNickname.Text = "Nickname";
            this.chNickname.Width = 261;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 65;
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(309, 57);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(47, 23);
            this.btnCerca.TabIndex = 6;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNome.Location = new System.Drawing.Point(12, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(128, 24);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome gruppo";
            // 
            // tbNomeGruppo
            // 
            this.tbNomeGruppo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeGruppo.Location = new System.Drawing.Point(146, 15);
            this.tbNomeGruppo.Name = "tbNomeGruppo";
            this.tbNomeGruppo.Size = new System.Drawing.Size(157, 29);
            this.tbNomeGruppo.TabIndex = 8;
            // 
            // nudIDcontatto
            // 
            this.nudIDcontatto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIDcontatto.Location = new System.Drawing.Point(146, 52);
            this.nudIDcontatto.Name = "nudIDcontatto";
            this.nudIDcontatto.Size = new System.Drawing.Size(157, 29);
            this.nudIDcontatto.TabIndex = 15;
            // 
            // rtbDescrizione
            // 
            this.rtbDescrizione.Location = new System.Drawing.Point(146, 100);
            this.rtbDescrizione.Name = "rtbDescrizione";
            this.rtbDescrizione.Size = new System.Drawing.Size(210, 126);
            this.rtbDescrizione.TabIndex = 16;
            this.rtbDescrizione.Text = "";
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrizione.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescrizione.Location = new System.Drawing.Point(8, 146);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(109, 24);
            this.lblDescrizione.TabIndex = 17;
            this.lblDescrizione.Text = "Descrizione";
            // 
            // FrmCreaGruppo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(371, 482);
            this.Controls.Add(this.lblDescrizione);
            this.Controls.Add(this.rtbDescrizione);
            this.Controls.Add(this.nudIDcontatto);
            this.Controls.Add(this.tbNomeGruppo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.lvContatti);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnCreaAggiungi);
            this.Name = "FrmCreaGruppo";
            this.Text = "Crea gruppo";
            this.Load += new System.EventHandler(this.FrmCreaGruppo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudIDcontatto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreaAggiungi;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ListView lvContatti;
        private System.Windows.Forms.ColumnHeader chNickname;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbNomeGruppo;
        private System.Windows.Forms.NumericUpDown nudIDcontatto;
        private System.Windows.Forms.RichTextBox rtbDescrizione;
        private System.Windows.Forms.Label lblDescrizione;
    }
}