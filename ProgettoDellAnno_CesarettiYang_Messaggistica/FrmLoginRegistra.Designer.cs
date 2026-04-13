namespace Messaggistica
{
    partial class FrmLoginRegistra
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.mtbNumero = new System.Windows.Forms.MaskedTextBox();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.lblNickname = new System.Windows.Forms.Label();
            this.btnRegistraLogin = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCambiaLoginRegistra = new System.Windows.Forms.Label();
            this.lbDataDiNascita = new System.Windows.Forms.Label();
            this.dtpDataDiNascita = new System.Windows.Forms.DateTimePicker();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbMostraPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(71, 136);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(150, 42);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero";
            // 
            // mtbNumero
            // 
            this.mtbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumero.Location = new System.Drawing.Point(437, 133);
            this.mtbNumero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbNumero.Mask = "+00 0000000000";
            this.mtbNumero.Name = "mtbNumero";
            this.mtbNumero.Size = new System.Drawing.Size(524, 49);
            this.mtbNumero.TabIndex = 1;
            // 
            // tbNickname
            // 
            this.tbNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNickname.Location = new System.Drawing.Point(437, 287);
            this.tbNickname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(524, 49);
            this.tbNickname.TabIndex = 2;
            this.tbNickname.Visible = false;
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickname.Location = new System.Drawing.Point(71, 291);
            this.lblNickname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(184, 42);
            this.lblNickname.TabIndex = 3;
            this.lblNickname.Text = "Nickname";
            this.lblNickname.Visible = false;
            // 
            // btnRegistraLogin
            // 
            this.btnRegistraLogin.Location = new System.Drawing.Point(0, 0);
            this.btnRegistraLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRegistraLogin.Name = "btnRegistraLogin";
            this.btnRegistraLogin.Size = new System.Drawing.Size(100, 27);
            this.btnRegistraLogin.TabIndex = 14;
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Green;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogin.Font = new System.Drawing.Font("MS Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(0, 0);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(1164, 69);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "LOGIN";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCambiaLoginRegistra
            // 
            this.lblCambiaLoginRegistra.Location = new System.Drawing.Point(0, 0);
            this.lblCambiaLoginRegistra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCambiaLoginRegistra.Name = "lblCambiaLoginRegistra";
            this.lblCambiaLoginRegistra.Size = new System.Drawing.Size(133, 27);
            this.lblCambiaLoginRegistra.TabIndex = 13;
            // 
            // lbDataDiNascita
            // 
            this.lbDataDiNascita.AutoSize = true;
            this.lbDataDiNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataDiNascita.Location = new System.Drawing.Point(71, 363);
            this.lbDataDiNascita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDataDiNascita.Name = "lbDataDiNascita";
            this.lbDataDiNascita.Size = new System.Drawing.Size(265, 42);
            this.lbDataDiNascita.TabIndex = 8;
            this.lbDataDiNascita.Text = "Data di nascita";
            this.lbDataDiNascita.Visible = false;
            // 
            // dtpDataDiNascita
            // 
            this.dtpDataDiNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDiNascita.Location = new System.Drawing.Point(437, 363);
            this.dtpDataDiNascita.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDataDiNascita.Name = "dtpDataDiNascita";
            this.dtpDataDiNascita.Size = new System.Drawing.Size(524, 46);
            this.dtpDataDiNascita.TabIndex = 9;
            this.dtpDataDiNascita.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(71, 210);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(183, 42);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(437, 207);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(524, 49);
            this.tbPassword.TabIndex = 10;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // cbMostraPassword
            // 
            this.cbMostraPassword.AutoSize = true;
            this.cbMostraPassword.Location = new System.Drawing.Point(437, 260);
            this.cbMostraPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbMostraPassword.Name = "cbMostraPassword";
            this.cbMostraPassword.Size = new System.Drawing.Size(149, 19);
            this.cbMostraPassword.TabIndex = 12;
            this.cbMostraPassword.Text = "Mostra password";
            this.cbMostraPassword.UseVisualStyleBackColor = true;
            // 
            // FrmLoginRegistra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 598);
            this.Controls.Add(this.cbMostraPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.dtpDataDiNascita);
            this.Controls.Add(this.lbDataDiNascita);
            this.Controls.Add(this.lblCambiaLoginRegistra);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnRegistraLogin);
            this.Controls.Add(this.lblNickname);
            this.Controls.Add(this.tbNickname);
            this.Controls.Add(this.mtbNumero);
            this.Controls.Add(this.lblNumero);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmLoginRegistra";
            this.Text = "FrmNuovoContatto";
            this.Load += new System.EventHandler(this.FrmLoginRegistra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.MaskedTextBox mtbNumero;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Button btnRegistraLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblCambiaLoginRegistra;
        private System.Windows.Forms.Label lbDataDiNascita;
        private System.Windows.Forms.DateTimePicker dtpDataDiNascita;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox cbMostraPassword;
    }
}