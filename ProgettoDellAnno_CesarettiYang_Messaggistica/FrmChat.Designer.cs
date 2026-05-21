namespace Messaggistica
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlElencoChat = new System.Windows.Forms.Panel();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnAggiungiContatto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lvElencoChat = new System.Windows.Forms.ListView();
            this.chChat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvChat = new System.Windows.Forms.ListView();
            this.chMessaggio1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMessaggio2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.btnCarica = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
<<<<<<< Updated upstream
            this.ptImpostazioni = new System.Windows.Forms.PictureBox();
=======
            this.tmMessaggi = new System.Windows.Forms.Timer(this.components);
>>>>>>> Stashed changes
            this.pnlElencoChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptImpostazioni)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlElencoChat
            // 
            this.pnlElencoChat.BackColor = System.Drawing.Color.Green;
            this.pnlElencoChat.Controls.Add(this.ptImpostazioni);
            this.pnlElencoChat.Controls.Add(this.btnElimina);
            this.pnlElencoChat.Controls.Add(this.btnAggiungiContatto);
            this.pnlElencoChat.Controls.Add(this.label2);
            this.pnlElencoChat.Controls.Add(this.lvElencoChat);
            this.pnlElencoChat.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlElencoChat.Location = new System.Drawing.Point(0, 0);
            this.pnlElencoChat.Name = "pnlElencoChat";
            this.pnlElencoChat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlElencoChat.Size = new System.Drawing.Size(200, 450);
            this.pnlElencoChat.TabIndex = 0;
            // 
<<<<<<< Updated upstream
=======
            // btnCreaGruppo
            // 
            this.btnCreaGruppo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreaGruppo.BackColor = System.Drawing.Color.Transparent;
            this.btnCreaGruppo.Location = new System.Drawing.Point(69, 386);
            this.btnCreaGruppo.Name = "btnCreaGruppo";
            this.btnCreaGruppo.Size = new System.Drawing.Size(60, 60);
            this.btnCreaGruppo.TabIndex = 8;
            this.btnCreaGruppo.Text = "Crea gruppo";
            this.btnCreaGruppo.UseVisualStyleBackColor = false;
            this.btnCreaGruppo.Click += new System.EventHandler(this.btnCreaGruppo_Click);
            // 
            // ptImpostazioni
            // 
            this.ptImpostazioni.Image = global::Messaggistica.Properties.Resources.Ingranaggio_removebg_preview__1_;
            this.ptImpostazioni.Location = new System.Drawing.Point(12, 12);
            this.ptImpostazioni.Name = "ptImpostazioni";
            this.ptImpostazioni.Size = new System.Drawing.Size(38, 35);
            this.ptImpostazioni.TabIndex = 0;
            this.ptImpostazioni.TabStop = false;
            this.ptImpostazioni.Click += new System.EventHandler(this.ptImpostazioni_Click);
            // 
>>>>>>> Stashed changes
            // btnElimina
            // 
            this.btnElimina.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnElimina.BackColor = System.Drawing.Color.Transparent;
            this.btnElimina.Location = new System.Drawing.Point(3, 386);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(60, 60);
            this.btnElimina.TabIndex = 7;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = false;
            // 
            // btnAggiungiContatto
            // 
            this.btnAggiungiContatto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAggiungiContatto.BackColor = System.Drawing.Color.Transparent;
            this.btnAggiungiContatto.Location = new System.Drawing.Point(137, 386);
            this.btnAggiungiContatto.Name = "btnAggiungiContatto";
            this.btnAggiungiContatto.Size = new System.Drawing.Size(60, 60);
            this.btnAggiungiContatto.TabIndex = 6;
            this.btnAggiungiContatto.Text = "Aggiungi";
            this.btnAggiungiContatto.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(53, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "<Nickname>";
            // 
            // lvElencoChat
            // 
            this.lvElencoChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvElencoChat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chChat});
            this.lvElencoChat.HideSelection = false;
            this.lvElencoChat.Location = new System.Drawing.Point(3, 66);
            this.lvElencoChat.Name = "lvElencoChat";
            this.lvElencoChat.Size = new System.Drawing.Size(194, 314);
            this.lvElencoChat.TabIndex = 1;
            this.lvElencoChat.UseCompatibleStateImageBehavior = false;
            this.lvElencoChat.View = System.Windows.Forms.View.Details;
            // 
            // chChat
            // 
            this.chChat.Text = "Chat";
            this.chChat.Width = 188;
            // 
            // lvChat
            // 
            this.lvChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvChat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMessaggio1,
            this.chMessaggio2});
            this.lvChat.HideSelection = false;
            this.lvChat.Location = new System.Drawing.Point(203, 66);
            this.lvChat.Name = "lvChat";
            this.lvChat.Size = new System.Drawing.Size(582, 314);
            this.lvChat.TabIndex = 2;
            this.lvChat.UseCompatibleStateImageBehavior = false;
            this.lvChat.View = System.Windows.Forms.View.Details;
            // 
            // chMessaggio1
            // 
            this.chMessaggio1.Text = "Messaggio";
            this.chMessaggio1.Width = 274;
            // 
            // chMessaggio2
            // 
            this.chMessaggio2.Text = "Messaggio";
<<<<<<< Updated upstream
            this.chMessaggio2.Width = 255;
=======
            this.chMessaggio2.Width = 271;
>>>>>>> Stashed changes
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(206, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "<nome gruppo/chat>";
            // 
            // richTextBox1
            // 
<<<<<<< Updated upstream
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox1.Location = new System.Drawing.Point(210, 386);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(465, 52);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Testo";
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(690, 386);
=======
            this.rtbMessaggio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMessaggio.ForeColor = System.Drawing.Color.Black;
            this.rtbMessaggio.Location = new System.Drawing.Point(210, 386);
            this.rtbMessaggio.Name = "rtbMessaggio";
            this.rtbMessaggio.Size = new System.Drawing.Size(465, 52);
            this.rtbMessaggio.TabIndex = 4;
            this.rtbMessaggio.Text = "";
            this.rtbMessaggio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbMessaggio_KeyDown);
            // 
            // btnInvia
            // 
            this.btnInvia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvia.Location = new System.Drawing.Point(681, 386);
>>>>>>> Stashed changes
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(75, 23);
            this.btnInvia.TabIndex = 5;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(690, 415);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(75, 23);
            this.btnCarica.TabIndex = 6;
            this.btnCarica.Text = "Carica";
            this.btnCarica.UseVisualStyleBackColor = true;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.Transparent;
            this.btnAggiungi.Location = new System.Drawing.Point(725, 12);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(60, 48);
            this.btnAggiungi.TabIndex = 8;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = false;
<<<<<<< Updated upstream
           
=======
            this.btnAggiungi.Visible = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // tmMessaggi
            // 
            this.tmMessaggi.Enabled = true;
            this.tmMessaggi.Interval = 5000;
            this.tmMessaggi.Tick += new System.EventHandler(this.tmMessaggi_Tick);
>>>>>>> Stashed changes
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.btnCarica);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvChat);
            this.Controls.Add(this.pnlElencoChat);
            this.Name = "FrmMain";
            this.Text = "Messaggistica";
            this.pnlElencoChat.ResumeLayout(false);
            this.pnlElencoChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptImpostazioni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlElencoChat;
        private System.Windows.Forms.ListView lvElencoChat;
        private System.Windows.Forms.ColumnHeader chChat;
        private System.Windows.Forms.ListView lvChat;
<<<<<<< Updated upstream
        private System.Windows.Forms.ColumnHeader chMessaggioInterlocutore;
        private System.Windows.Forms.Label label2;
=======
        private System.Windows.Forms.Label lblNickname;
>>>>>>> Stashed changes
        private System.Windows.Forms.ColumnHeader chMessaggio1;
        private System.Windows.Forms.ColumnHeader chMessaggio2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnAggiungiContatto;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.PictureBox ptImpostazioni;
<<<<<<< Updated upstream
=======
        private System.Windows.Forms.Button btnCreaGruppo;
        private System.Windows.Forms.ListView lvElencoChat;
        private System.Windows.Forms.ColumnHeader chChat;
        private System.Windows.Forms.Timer tmMessaggi;
>>>>>>> Stashed changes
    }
}

