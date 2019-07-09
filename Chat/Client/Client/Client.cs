using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {
        private TcpClient client = null;
        private BinaryReader reading = null;
        private BinaryWriter writing = null;        

        public ClientForm()
        {
            InitializeComponent();
            wbConversation.DocumentText = "<html><body><div id='conversation'></div></body></html>";
            tbHostAddress.Text = "127.0.0.1";
            nUDPort.Text = "300";
            btSend.Enabled = false;
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            bwConnection.RunWorkerAsync();
        }

        private void bwConnection_DoWork(object sender, DoWorkEventArgs e)
        {
            string host = tbHostAddress.Text;
            int port = System.Convert.ToInt16(nUDPort.Value);
            try
            {
                client = new TcpClient(host, port);
                lbMessage.Invoke(new MethodInvoker(delegate { lbMessage.Items.Add("Nawiązano połączenie z: " + host + " na porcie: " + port); }));
                NetworkStream ns = client.GetStream();
                reading = new BinaryReader(ns);
                writing = new BinaryWriter(ns);
                writing.Write(tbNick.Text);
                btSend.Invoke(new MethodInvoker(delegate { btSend.Enabled = true; }));
                btConnect.Invoke(new MethodInvoker(delegate { btConnect.Enabled = false; }));
                bwMessages = new BackgroundWorker();
                bwMessages.DoWork += bwMessages_DoWork;
                bwMessages.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                lbMessage.Invoke(new MethodInvoker(delegate { lbMessage.Items.Add("Błąd: Nie udało się nawiązać połączenia!"); }));
                MessageBox.Show(ex.ToString());
            }
        }

        private void bwMessages_DoWork(object sender, DoWorkEventArgs e)
        {
            string messageReceived = "";
            while((messageReceived) != "END")
            {
                try
                {
                    messageReceived = reading.ReadString();
                    Console.WriteLine("odebrano: " + messageReceived);
                    wbConversation.Invoke(new MethodInvoker(delegate {
                        string[] words = messageReceived.Split('&');
                        string nickname = words[0];
                        string color = words[1];
                        messageReceived = words[2];
                        HtmlElement conv = wbConversation.Document.GetElementById("conversation");
                        HtmlElement p = wbConversation.Document.CreateElement("p");
                        p.Style = "color:" + color;
                        p.InnerHtml += "[" + nickname + "]" + messageReceived;
                        conv.AppendChild(p);
                        Console.WriteLine(conv.InnerHtml);                   
                    }));
                }
                catch
                {
                    wbConversation.Invoke(new MethodInvoker(delegate {
                        HtmlElement conv = wbConversation.Document.GetElementById("conversation");
                        conv.InnerHtml += "Serwer rozłączył się.";
                    }));
                    Console.WriteLine("Koniec połączenia.");
                    btConnect.Invoke(new MethodInvoker(delegate
                    {
                        btConnect.Enabled = true;
                    }));
                    bwConnection.CancelAsync();
                    btSend.Invoke(new MethodInvoker(delegate
                    {
                        btSend.Enabled = false;
                    }));
                    break;
                }
            }
            client.Close();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            string messageSent = tbMessage.Text;
            writing.Write(messageSent);
        }

        private void lbEmojis_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMessage.Text += lbEmojis.GetItemText(lbEmojis.SelectedItem);
        }
    }
}
