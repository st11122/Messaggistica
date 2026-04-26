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
            this.lblNumero = new System.Windows.Forms.Label();
            this.mtbNumero = new System.Windows.Forms.MaskedTextBox();
            this.lvContatti = new System.Windows.Forms.ListView();
            this.chNickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCerca = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreaAggiungi
            // 
            this.btnCreaAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreaAggiungi.Location = new System.Drawing.Point(199, 296);
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
            this.btnAnnulla.Location = new System.Drawing.Point(12, 296);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(157, 36);
            this.btnAnnulla.TabIndex = 1;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumero.Location = new System.Drawing.Point(12, 57);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(79, 24);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Numero";
            // 
            // mtbNumero
            // 
            this.mtbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumero.Location = new System.Drawing.Point(111, 54);
            this.mtbNumero.Mask = "+00 0000000000";
            this.mtbNumero.Name = "mtbNumero";
            this.mtbNumero.Size = new System.Drawing.Size(150, 29);
            this.mtbNumero.TabIndex = 4;
            // 
            // lvContatti
            // 
            this.lvContatti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNickname,
            this.chNumero});
            this.lvContatti.FullRowSelect = true;
            this.lvContatti.HideSelection = false;
            this.lvContatti.Location = new System.Drawing.Point(12, 94);
            this.lvContatti.Name = "lvContatti";
            this.lvContatti.Size = new System.Drawing.Size(344, 179);
            this.lvContatti.TabIndex = 5;
            this.lvContatti.UseCompatibleStateImageBehavior = false;
            this.lvContatti.View = System.Windows.Forms.View.Details;
            // 
            // chNickname
            // 
            this.chNickname.Text = "Nickname";
            this.chNickname.Width = 160;
            // 
            // chNumero
            // 
            this.chNumero.Text = "Numero";
            this.chNumero.Width = 169;
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(267, 57);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(75, 23);
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
            this.lblNome.Size = new System.Drawing.Size(62, 24);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(111, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 29);
            this.textBox1.TabIndex = 8;
            // 
            // FrmCreaGruppo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(368, 344);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.lvContatti);
            this.Controls.Add(this.mtbNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnCreaAggiungi);
            this.Name = "FrmCreaGruppo";
            this.Text = "Crea gruppo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreaAggiungi;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.MaskedTextBox mtbNumero;
        private System.Windows.Forms.ListView lvContatti;
        private System.Windows.Forms.ColumnHeader chNickname;
        private System.Windows.Forms.ColumnHeader chNumero;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBox1;
    }
}