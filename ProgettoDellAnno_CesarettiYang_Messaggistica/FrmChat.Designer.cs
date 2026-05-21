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
            this.btnCreaGruppo = new System.Windows.Forms.Button();
            this.ptImpostazioni = new System.Windows.Forms.PictureBox();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnAggiungiContatto = new System.Windows.Forms.Button();
            this.lblNickname = new System.Windows.Forms.Label();
            this.lvElencoChat = new System.Windows.Forms.ListView();
            this.chChat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvChat = new System.Windows.Forms.ListView();
            this.chMessaggio1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMessaggio2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNomeGruppoOChat = new System.Windows.Forms.Label();
            this.rtbMessaggio = new System.Windows.Forms.RichTextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.btnTestDiConnessione = new System.Windows.Forms.Button();
=======
<<<<<<< Updated upstream
            this.ptImpostazioni = new System.Windows.Forms.PictureBox();
=======
            this.tmMessaggi = new System.Windows.Forms.Timer(this.components);
>>>>>>> Stashed changes
>>>>>>> Chat
            this.pnlElencoChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptImpostazioni)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlElencoChat
            // 
            this.pnlElencoChat.BackColor = System.Drawing.Color.Green;
            this.pnlElencoChat.Controls.Add(this.btnCreaGruppo);
            this.pnlElencoChat.Controls.Add(this.ptImpostazioni);
            this.pnlElencoChat.Controls.Add(this.btnElimina);
            this.pnlElencoChat.Controls.Add(this.btnAggiungiContatto);
            this.pnlElencoChat.Controls.Add(this.lblNickname);
            this.pnlElencoChat.Controls.Add(this.lvElencoChat);
            this.pnlElencoChat.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlElencoChat.Location = new System.Drawing.Point(0, 0);
            this.pnlElencoChat.Name = "pnlElencoChat";
            this.pnlElencoChat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlElencoChat.Size = new System.Drawing.Size(200, 450);
            this.pnlElencoChat.TabIndex = 0;
            // 
<<<<<<< HEAD
            // btnCreaGruppo
            // 
=======
<<<<<<< Updated upstream
=======
            // btnCreaGruppo
            // 
            this.btnCreaGruppo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
>>>>>>> Chat
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
<<<<<<< HEAD
=======
>>>>>>> Stashed changes
>>>>>>> Chat
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
            this.btnAggiungiContatto.Click += new System.EventHandler(this.btnAggiungiContatto_Click);
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNickname.Location = new System.Drawing.Point(68, 22);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(117, 24);
            this.lblNickname.TabIndex = 4;
            this.lblNickname.Text = "<Nickname>";
            // 
            // lvElencoChat
            // 
            this.lvElencoChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvElencoChat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chChat});
            this.lvElencoChat.FullRowSelect = true;
            this.lvElencoChat.HideSelection = false;
            this.lvElencoChat.Location = new System.Drawing.Point(3, 66);
            this.lvElencoChat.MultiSelect = false;
            this.lvElencoChat.Name = "lvElencoChat";
            this.lvElencoChat.Size = new System.Drawing.Size(194, 314);
            this.lvElencoChat.TabIndex = 1;
            this.lvElencoChat.UseCompatibleStateImageBehavior = false;
            this.lvElencoChat.View = System.Windows.Forms.View.Details;
            this.lvElencoChat.SelectedIndexChanged += new System.EventHandler(this.lvElencoChat_SelectedIndexChanged);
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
<<<<<<< HEAD
            this.chMessaggio2.Width = 253;
=======
<<<<<<< Updated upstream
            this.chMessaggio2.Width = 255;
=======
            this.chMessaggio2.Width = 271;
>>>>>>> Stashed changes
>>>>>>> Chat
            // 
            // lblNomeGruppoOChat
            // 
            this.lblNomeGruppoOChat.AutoSize = true;
            this.lblNomeGruppoOChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGruppoOChat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNomeGruppoOChat.Location = new System.Drawing.Point(206, 22);
            this.lblNomeGruppoOChat.Name = "lblNomeGruppoOChat";
            this.lblNomeGruppoOChat.Size = new System.Drawing.Size(187, 24);
            this.lblNomeGruppoOChat.TabIndex = 3;
            this.lblNomeGruppoOChat.Text = "<nome gruppo/chat>";
            this.lblNomeGruppoOChat.Click += new System.EventHandler(this.lblNomeGruppoOChat_Click);
            // 
            // rtbMessaggio
            // 
<<<<<<< HEAD
            this.rtbMessaggio.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rtbMessaggio.Location = new System.Drawing.Point(210, 386);
            this.rtbMessaggio.Name = "rtbMessaggio";
            this.rtbMessaggio.Size = new System.Drawing.Size(465, 52);
            this.rtbMessaggio.TabIndex = 4;
            this.rtbMessaggio.Text = "Testo";
            // 
            // btnInvia
            // 
            this.btnInvia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvia.Location = new System.Drawing.Point(681, 386);
=======
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
>>>>>>> Chat
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(104, 52);
            this.btnInvia.TabIndex = 5;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
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
<<<<<<< HEAD
            this.btnAggiungi.Visible = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnTestDiConnessione
            // 
            this.btnTestDiConnessione.BackColor = System.Drawing.Color.Transparent;
            this.btnTestDiConnessione.Location = new System.Drawing.Point(471, 12);
            this.btnTestDiConnessione.Name = "btnTestDiConnessione";
            this.btnTestDiConnessione.Size = new System.Drawing.Size(60, 48);
            this.btnTestDiConnessione.TabIndex = 9;
            this.btnTestDiConnessione.Text = "Test di connessione";
            this.btnTestDiConnessione.UseVisualStyleBackColor = false;
            this.btnTestDiConnessione.Click += new System.EventHandler(this.btnTestDiConnessione_Click);
=======
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
>>>>>>> Chat
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTestDiConnessione);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.rtbMessaggio);
            this.Controls.Add(this.lblNomeGruppoOChat);
            this.Controls.Add(this.lvChat);
            this.Controls.Add(this.pnlElencoChat);
            this.Name = "FrmMain";
            this.Text = "Messaggistica";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlElencoChat.ResumeLayout(false);
            this.pnlElencoChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptImpostazioni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlElencoChat;
        private System.Windows.Forms.ListView lvChat;
<<<<<<< Updated upstream
        private System.Windows.Forms.ColumnHeader chMessaggioInterlocutore;
<<<<<<< HEAD
        private System.Windows.Forms.Label lblNickname;
=======
        private System.Windows.Forms.Label label2;
=======
        private System.Windows.Forms.Label lblNickname;
>>>>>>> Stashed changes
>>>>>>> Chat
        private System.Windows.Forms.ColumnHeader chMessaggio1;
        private System.Windows.Forms.ColumnHeader chMessaggio2;
        private System.Windows.Forms.Label lblNomeGruppoOChat;
        private System.Windows.Forms.RichTextBox rtbMessaggio;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnAggiungiContatto;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.PictureBox ptImpostazioni;
<<<<<<< HEAD
        private System.Windows.Forms.Button btnCreaGruppo;
        private System.Windows.Forms.Button btnTestDiConnessione;
        private System.Windows.Forms.ListView lvElencoChat;
        private System.Windows.Forms.ColumnHeader chChat;
=======
<<<<<<< Updated upstream
=======
        private System.Windows.Forms.Button btnCreaGruppo;
        private System.Windows.Forms.ListView lvElencoChat;
        private System.Windows.Forms.ColumnHeader chChat;
        private System.Windows.Forms.Timer tmMessaggi;
>>>>>>> Stashed changes
>>>>>>> Chat
    }
}

