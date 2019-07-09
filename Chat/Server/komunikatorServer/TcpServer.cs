using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace komunikatorServer
{
    public partial class TcpServer : Form
    {
        private TcpListener server;
        public static List<handleClient> clients = new List<handleClient>();

        public TcpServer()
        {
            InitializeComponent();
            wbConversation.DocumentText = "<html><body><div id='conversation'></div></body></html>";
            tbHostAddress.Text = "127.0.0.1";
            nUDPort.Text = "300";
            btSend.Enabled = false;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            bwConnection.RunWorkerAsync();
            bStop.Enabled = true;
        }

        public class handleClient
        {
            private static TcpClient clientSocket;
            private static NetworkStream ns;
            private BinaryReader reading;
            public BinaryWriter writing;
            private string messageReceived;
            private string nickname;
            private int howManyMessages = 0;
            private TcpServer tcpServer;
            public Thread ctThread;
            string color = generateColor();

            private static string generateColor()
            {
                Random rnd = new Random();
                int r = rnd.Next(0, 255);
                int g = rnd.Next(0, 255);
                int b = rnd.Next(0, 255);
                return "rgb(" + r + "," + g + "," + b + ")";
            }

            public handleClient(TcpServer tcpServer)
            {
                this.tcpServer = tcpServer;
            }

            public void startClient(TcpClient inClientSocket)
            {
                clientSocket = inClientSocket;
                ns = clientSocket.GetStream();
                reading = new BinaryReader(ns);
                writing = new BinaryWriter(ns);
                messageReceived = "";
                ctThread = new Thread(Chat);
                ctThread.IsBackground = true;
                ctThread.Start();
            }

            private void Chat()
            {
                while ((messageReceived) != "END")
                {
                    try
                    {
                        messageReceived = reading.ReadString();
                        Console.WriteLine("Odebrano:" + messageReceived);
                        Console.Write(color);
                        howManyMessages++;
                        if (howManyMessages == 1)
                        {
                            nickname = messageReceived;
                        }
                        else
                        {
                            tcpServer.wbConversation.Invoke(new MethodInvoker(delegate {
                                HtmlElement conv = tcpServer.wbConversation.Document.GetElementById("conversation");
                                HtmlElement p = tcpServer.wbConversation.Document.CreateElement("p");
                                p.Style = "color:" + color;
                                p.InnerHtml += "[" + nickname + "]" + messageReceived;
                                conv.AppendChild(p);
                                Console.WriteLine(conv.InnerHtml);
                            }));
                            foreach (var client in clients)
                            {
                                //send message to client
                                client.writing.Write(nickname + "&" + color + "&" + messageReceived);
                                Console.WriteLine("Wysyłam" + messageReceived);
                            }
                        }
                    }
                    catch
                    {
                        tcpServer.wbConversation.Invoke(new MethodInvoker(delegate
                        {
                            HtmlElement conv = tcpServer.wbConversation.Document.GetElementById("conversation");
                            conv.InnerHtml += nickname + " rozłączył się.<br>";
                        }));
                        clients.Remove(this);
                        tcpServer.lbNumberOfClients.Invoke(new MethodInvoker(delegate {
                            tcpServer.lbNumberOfClients.Text = clients.Count.ToString();
                            if (clients.Count == 0)
                                tcpServer.btSend.Enabled = false;
                        }));
                        break;
                    }
                }
            }

            internal void stop()
            {
                clientSocket.Close();
            }
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            if (bwConnection.WorkerSupportsCancellation == true)
            {
                bwConnection.CancelAsync();
            }

            foreach(handleClient client in clients)
            {
                client.stop();
            }

            server.Stop();
            clients.Clear();
            lbNumberOfClients.Text = clients.Count.ToString();
            lbMessage.Items.Add("Zakończono pracę serwera...");
            bStart.Enabled = true;
            bStop.Enabled = false;
            btSend.Enabled = false;
        }

        private void bwConnection_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            IPAddress adresIP = null;

            try
            {
                adresIP = IPAddress.Parse(tbHostAddress.Text);

            }
            catch
            {
                MessageBox.Show("Błędny format adresu IP!", "Błąd");
                return;
            }

            int port = System.Convert.ToInt16(nUDPort.Value);

            try
            {
                server = new TcpListener(adresIP, port);

                server.Start();

                lbMessage.Invoke(new MethodInvoker(delegate
                {
                    lbMessage.Items.Add("[SERVER]Oczekiwanie na połączenie...");
                    bStart.Enabled = false;
                }));

                while (worker.CancellationPending != true)
                {
                    try
                    {
                        TcpClient clientSocket = server.AcceptTcpClient();
                        handleClient client = new handleClient(this);
                        IPEndPoint IP = (IPEndPoint)clientSocket.Client.RemoteEndPoint;
                        client.startClient(clientSocket);
                        clients.Add(client);
                        lbNumberOfClients.Invoke(new MethodInvoker(delegate
                        {
                            lbNumberOfClients.Text = clients.Count.ToString();
                        }));
                        lbMessage.Invoke(new MethodInvoker(delegate
                        {
                            lbMessage.Items.Add("[" + IP.ToString() + "]: Nawiązano połączenie.");
                            btSend.Enabled = true;
                            bStop.Enabled = true;
                        }));
                    }

                    catch (SocketException)
                    {
                        Console.WriteLine("Koniec");
                        //client.
                    }
                }
                Console.WriteLine("Koniec połączenia.");
                e.Cancel = true;
            }

            catch (Exception ex)
            {
                lbMessage.Invoke(new MethodInvoker(delegate { lbMessage.Items.Add("[SERVER]Błąd inicjacji serwera!"); }));
                MessageBox.Show(ex.ToString(), "Błąd.");
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            string message = tbMessage.Text;
            HtmlElement conv = wbConversation.Document.GetElementById("conversation");
            HtmlElement p = wbConversation.Document.CreateElement("p");
            p.Style = "color:red";
            p.InnerHtml += "[SERVER]" + message;
            conv.AppendChild(p);
            foreach (var client in clients)
            {
                //send message to client
                client.writing.Write("SERVER&red&" + message);
                Console.WriteLine("Wysyłam" + message);
            }
        }
    }
}
