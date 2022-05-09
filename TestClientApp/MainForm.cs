using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace TestClientApp
{
    public partial class MainForm : Form
    {
        const string ip = "127.0.0.1";
        const int port = 8080;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void BTEnter_Click(object sender, EventArgs e)
        {
            if (TBEnter.Text != "")
            {
                try
                {
                    var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

                    var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    var message = TBEnter.Text;

                    var data = Encoding.UTF8.GetBytes(message);

                    tcpSocket.Connect(tcpEndPoint);
                    tcpSocket.Send(data);

                    var buffer = new byte[256];
                    var size = 0;
                    var answer = new StringBuilder();

                    do
                    {
                        size = tcpSocket.Receive(buffer);
                        answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
                    }
                    while (tcpSocket.Available > 0);

                    labelAnswer.Text = (answer.ToString());

                    tcpSocket.Shutdown(SocketShutdown.Both);
                    tcpSocket.Close();
                }
                catch (Exception Exceptions)
                {
                    MessageBox.Show($"{Exceptions.ToString()}", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else
            {
                MessageBox.Show("Введите сообщение", null, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void TBEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { BTEnter_Click(BTEnter, null); }
        }
    }
}
