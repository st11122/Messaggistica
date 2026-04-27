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
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.lblNickname = new System.Windows.Forms.Label();
            this.btnRegistraLogin = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblDataDiNascita = new System.Windows.Forms.Label();
            this.dtpDataDiNascita = new System.Windows.Forms.DateTimePicker();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbMostraPassword = new System.Windows.Forms.CheckBox();
            this.btnAccediRegistra = new System.Windows.Forms.Button();
            this.rtbBiografia = new System.Windows.Forms.RichTextBox();
            this.lblBiografia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNickname
            // 
            this.tbNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNickname.Location = new System.Drawing.Point(360, 100);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(394, 40);
            this.tbNickname.TabIndex = 2;
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickname.Location = new System.Drawing.Point(85, 103);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(146, 33);
            this.lblNickname.TabIndex = 3;
            this.lblNickname.Text = "Nickname";
            // 
            // btnRegistraLogin
            // 
            this.btnRegistraLogin.Location = new System.Drawing.Point(0, 0);
            this.btnRegistraLogin.Name = "btnRegistraLogin";
            this.btnRegistraLogin.Size = new System.Drawing.Size(75, 23);
            this.btnRegistraLogin.TabIndex = 14;
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Green;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogin.Font = new System.Drawing.Font("MS Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(0, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(873, 60);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "LOGIN";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDataDiNascita
            // 
            this.lblDataDiNascita.AutoSize = true;
            this.lblDataDiNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDiNascita.Location = new System.Drawing.Point(85, 257);
            this.lblDataDiNascita.Name = "lblDataDiNascita";
            this.lblDataDiNascita.Size = new System.Drawing.Size(208, 33);
            this.lblDataDiNascita.TabIndex = 8;
            this.lblDataDiNascita.Text = "Data di nascita";
            this.lblDataDiNascita.Visible = false;
            // 
            // dtpDataDiNascita
            // 
            this.dtpDataDiNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDiNascita.Location = new System.Drawing.Point(360, 257);
            this.dtpDataDiNascita.Name = "dtpDataDiNascita";
            this.dtpDataDiNascita.Size = new System.Drawing.Size(394, 38);
            this.dtpDataDiNascita.TabIndex = 9;
            this.dtpDataDiNascita.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(85, 167);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(143, 33);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(360, 164);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(394, 40);
            this.tbPassword.TabIndex = 10;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // cbMostraPassword
            // 
            this.cbMostraPassword.AutoSize = true;
            this.cbMostraPassword.Location = new System.Drawing.Point(360, 215);
            this.cbMostraPassword.Name = "cbMostraPassword";
            this.cbMostraPassword.Size = new System.Drawing.Size(106, 17);
            this.cbMostraPassword.TabIndex = 12;
            this.cbMostraPassword.Text = "Mostra password";
            this.cbMostraPassword.UseVisualStyleBackColor = true;
            this.cbMostraPassword.CheckedChanged += new System.EventHandler(this.cbMostraPassword_CheckedChanged);
            // 
            // btnAccediRegistra
            // 
            this.btnAccediRegistra.BackColor = System.Drawing.Color.Green;
            this.btnAccediRegistra.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccediRegistra.ForeColor = System.Drawing.Color.White;
            this.btnAccediRegistra.Location = new System.Drawing.Point(285, 420);
            this.btnAccediRegistra.Name = "btnAccediRegistra";
            this.btnAccediRegistra.Size = new System.Drawing.Size(202, 67);
            this.btnAccediRegistra.TabIndex = 15;
            this.btnAccediRegistra.Text = "Accedi";
            this.btnAccediRegistra.UseVisualStyleBackColor = false;
            this.btnAccediRegistra.Click += new System.EventHandler(this.btnAccediRegistra_Click);
            // 
            // rtbBiografia
            // 
            this.rtbBiografia.Location = new System.Drawing.Point(360, 318);
            this.rtbBiografia.Name = "rtbBiografia";
            this.rtbBiografia.Size = new System.Drawing.Size(394, 79);
            this.rtbBiografia.TabIndex = 16;
            this.rtbBiografia.Text = "";
            this.rtbBiografia.Visible = false;
            // 
            // lblBiografia
            // 
            this.lblBiografia.AutoSize = true;
            this.lblBiografia.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiografia.Location = new System.Drawing.Point(85, 318);
            this.lblBiografia.Name = "lblBiografia";
            this.lblBiografia.Size = new System.Drawing.Size(130, 33);
            this.lblBiografia.TabIndex = 17;
            this.lblBiografia.Text = "Biografia";
            this.lblBiografia.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Se non hai un\'account";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCambio.Location = new System.Drawing.Point(462, 523);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(79, 24);
            this.lblCambio.TabIndex = 19;
            this.lblCambio.Text = "registrati";
            this.lblCambio.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmLoginRegistra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 586);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBiografia);
            this.Controls.Add(this.rtbBiografia);
            this.Controls.Add(this.btnAccediRegistra);
            this.Controls.Add(this.cbMostraPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.dtpDataDiNascita);
            this.Controls.Add(this.lblDataDiNascita);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnRegistraLogin);
            this.Controls.Add(this.lblNickname);
            this.Controls.Add(this.tbNickname);
            this.Name = "FrmLoginRegistra";
            this.Text = "AccediRegistra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Button btnRegistraLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblDataDiNascita;
        private System.Windows.Forms.DateTimePicker dtpDataDiNascita;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox cbMostraPassword;
        private System.Windows.Forms.Button btnAccediRegistra;
        private System.Windows.Forms.RichTextBox rtbBiografia;
        private System.Windows.Forms.Label lblBiografia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCambio;
    }
}