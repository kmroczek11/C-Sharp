namespace Client
{
    partial class ClientForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMessage = new System.Windows.Forms.ListBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.nUDPort = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHostAddress = new System.Windows.Forms.TextBox();
            this.bwConnection = new System.ComponentModel.BackgroundWorker();
            this.bwMessages = new System.ComponentModel.BackgroundWorker();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.lEnterMessage = new System.Windows.Forms.Label();
            this.lbNick = new System.Windows.Forms.Label();
            this.tbNick = new System.Windows.Forms.TextBox();
            this.wbConversation = new System.Windows.Forms.WebBrowser();
            this.lbEmojis = new System.Windows.Forms.ListBox();
            this.lbChoose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPort)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.FormattingEnabled = true;
            this.lbMessage.ItemHeight = 16;
            this.lbMessage.Location = new System.Drawing.Point(73, 103);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(276, 36);
            this.lbMessage.TabIndex = 11;
            // 
            // btConnect
            // 
            this.btConnect.BackColor = System.Drawing.Color.Wheat;
            this.btConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConnect.Location = new System.Drawing.Point(520, 112);
            this.btConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(87, 28);
            this.btConnect.TabIndex = 10;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = false;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // nUDPort
            // 
            this.nUDPort.Location = new System.Drawing.Point(520, 43);
            this.nUDPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nUDPort.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.nUDPort.Name = "nUDPort";
            this.nUDPort.Size = new System.Drawing.Size(140, 21);
            this.nUDPort.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Address";
            // 
            // tbHostAddress
            // 
            this.tbHostAddress.Location = new System.Drawing.Point(157, 42);
            this.tbHostAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbHostAddress.Name = "tbHostAddress";
            this.tbHostAddress.Size = new System.Drawing.Size(192, 21);
            this.tbHostAddress.TabIndex = 6;
            // 
            // bwConnection
            // 
            this.bwConnection.WorkerSupportsCancellation = true;
            this.bwConnection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConnection_DoWork);
            // 
            // bwMessages
            // 
            this.bwMessages.WorkerSupportsCancellation = true;
            this.bwMessages.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwMessages_DoWork);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(432, 318);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(296, 24);
            this.tbMessage.TabIndex = 13;
            // 
            // btSend
            // 
            this.btSend.BackColor = System.Drawing.Color.Wheat;
            this.btSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSend.Location = new System.Drawing.Point(640, 350);
            this.btSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(87, 28);
            this.btSend.TabIndex = 14;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = false;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // lEnterMessage
            // 
            this.lEnterMessage.AutoSize = true;
            this.lEnterMessage.Location = new System.Drawing.Point(428, 281);
            this.lEnterMessage.Name = "lEnterMessage";
            this.lEnterMessage.Size = new System.Drawing.Size(86, 16);
            this.lEnterMessage.TabIndex = 15;
            this.lEnterMessage.Text = "Enter message:";
            // 
            // lbNick
            // 
            this.lbNick.AutoSize = true;
            this.lbNick.Location = new System.Drawing.Point(432, 178);
            this.lbNick.Name = "lbNick";
            this.lbNick.Size = new System.Drawing.Size(66, 16);
            this.lbNick.TabIndex = 16;
            this.lbNick.Text = "Podaj nick:";
            // 
            // tbNick
            // 
            this.tbNick.Location = new System.Drawing.Point(435, 212);
            this.tbNick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNick.Name = "tbNick";
            this.tbNick.Size = new System.Drawing.Size(116, 21);
            this.tbNick.TabIndex = 17;
            this.tbNick.Text = "Anonymous";
            // 
            // wbConversation
            // 
            this.wbConversation.Location = new System.Drawing.Point(73, 178);
            this.wbConversation.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbConversation.Name = "wbConversation";
            this.wbConversation.Size = new System.Drawing.Size(276, 295);
            this.wbConversation.TabIndex = 18;
            // 
            // lbEmojis
            // 
            this.lbEmojis.FormattingEnabled = true;
            this.lbEmojis.ItemHeight = 16;
            this.lbEmojis.Items.AddRange(new object[] {
            "😀",
            "😁",
            "😂",
            "😭"});
            this.lbEmojis.Location = new System.Drawing.Point(665, 180);
            this.lbEmojis.Name = "lbEmojis";
            this.lbEmojis.Size = new System.Drawing.Size(20, 68);
            this.lbEmojis.TabIndex = 19;
            this.lbEmojis.SelectedIndexChanged += new System.EventHandler(this.lbEmojis_SelectedIndexChanged);
            // 
            // lbChoose
            // 
            this.lbChoose.AutoSize = true;
            this.lbChoose.Location = new System.Drawing.Point(637, 161);
            this.lbChoose.Name = "lbChoose";
            this.lbChoose.Size = new System.Drawing.Size(81, 16);
            this.lbChoose.TabIndex = 20;
            this.lbChoose.Text = "Dodaj emotkę";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(772, 519);
            this.Controls.Add(this.lbChoose);
            this.Controls.Add(this.lbEmojis);
            this.Controls.Add(this.wbConversation);
            this.Controls.Add(this.tbNick);
            this.Controls.Add(this.lbNick);
            this.Controls.Add(this.lEnterMessage);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.nUDPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHostAddress);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ClientForm";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.nUDPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMessage;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.NumericUpDown nUDPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHostAddress;
        private System.ComponentModel.BackgroundWorker bwConnection;
        private System.ComponentModel.BackgroundWorker bwMessages;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Label lEnterMessage;
        private System.Windows.Forms.Label lbNick;
        private System.Windows.Forms.TextBox tbNick;
        private System.Windows.Forms.WebBrowser wbConversation;
        private System.Windows.Forms.ListBox lbEmojis;
        private System.Windows.Forms.Label lbChoose;
    }
}

