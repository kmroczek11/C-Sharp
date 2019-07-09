namespace komunikatorServer
{
    partial class TcpServer
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
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nUDPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHostAddress = new System.Windows.Forms.TextBox();
            this.wbConversation = new System.Windows.Forms.WebBrowser();
            this.bwConnection = new System.ComponentModel.BackgroundWorker();
            this.lbClients = new System.Windows.Forms.Label();
            this.lbNumberOfClients = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPort)).BeginInit();
            this.SuspendLayout();
            // 
            // bStop
            // 
            this.bStop.BackColor = System.Drawing.Color.LemonChiffon;
            this.bStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bStop.Location = new System.Drawing.Point(647, 511);
            this.bStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(75, 30);
            this.bStop.TabIndex = 13;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = false;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.Color.LemonChiffon;
            this.bStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bStart.Location = new System.Drawing.Point(565, 511);
            this.bStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(76, 30);
            this.bStart.TabIndex = 12;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.FormattingEnabled = true;
            this.lbMessage.ItemHeight = 17;
            this.lbMessage.Location = new System.Drawing.Point(36, 88);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(520, 72);
            this.lbMessage.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Port";
            // 
            // nUDPort
            // 
            this.nUDPort.Location = new System.Drawing.Point(469, 43);
            this.nUDPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nUDPort.Maximum = new decimal(new int[] {
            7000,
            0,
            0,
            0});
            this.nUDPort.Name = "nUDPort";
            this.nUDPort.Size = new System.Drawing.Size(87, 23);
            this.nUDPort.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Address";
            // 
            // tbHostAddress
            // 
            this.tbHostAddress.Location = new System.Drawing.Point(92, 42);
            this.tbHostAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbHostAddress.Name = "tbHostAddress";
            this.tbHostAddress.Size = new System.Drawing.Size(272, 23);
            this.tbHostAddress.TabIndex = 7;
            // 
            // wbConversation
            // 
            this.wbConversation.Location = new System.Drawing.Point(36, 214);
            this.wbConversation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wbConversation.MinimumSize = new System.Drawing.Size(23, 26);
            this.wbConversation.Name = "wbConversation";
            this.wbConversation.Size = new System.Drawing.Size(520, 327);
            this.wbConversation.TabIndex = 20;
            // 
            // bwConnection
            // 
            this.bwConnection.WorkerSupportsCancellation = true;
            this.bwConnection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConnection_DoWork);
            // 
            // lbClients
            // 
            this.lbClients.AutoSize = true;
            this.lbClients.Location = new System.Drawing.Point(644, 52);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(77, 17);
            this.lbClients.TabIndex = 21;
            this.lbClients.Text = "Ilu klientów:";
            // 
            // lbNumberOfClients
            // 
            this.lbNumberOfClients.AutoSize = true;
            this.lbNumberOfClients.Location = new System.Drawing.Point(656, 88);
            this.lbNumberOfClients.Name = "lbNumberOfClients";
            this.lbNumberOfClients.Size = new System.Drawing.Size(15, 17);
            this.lbNumberOfClients.TabIndex = 22;
            this.lbNumberOfClients.Text = "0";
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(619, 315);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 23;
            this.btSend.Text = "Wyślij";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(600, 263);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(121, 23);
            this.tbMessage.TabIndex = 24;
            // 
            // TcpServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(750, 632);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.lbNumberOfClients);
            this.Controls.Add(this.lbClients);
            this.Controls.Add(this.wbConversation);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nUDPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHostAddress);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TcpServer";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.nUDPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.ListBox lbMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUDPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHostAddress;
        private System.Windows.Forms.WebBrowser wbConversation;
        private System.ComponentModel.BackgroundWorker bwConnection;
        private System.Windows.Forms.Label lbClients;
        private System.Windows.Forms.Label lbNumberOfClients;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox tbMessage;
    }
}

