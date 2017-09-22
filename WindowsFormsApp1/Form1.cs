using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        static Socket sock;
        public Form1()
        {
            InitializeComponent();
            txtportnumber.MaxLength = 5;
        }

        private void txtipaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {

            if ((txtipaddress.Text =="" && txthostname.Text== "") || txtportnumber.Text == "")
            {
                MessageBox.Show("Please endter valid ip address and port number");
            }

            else if (txthostname.Text== "")
            {
                String ip = txtipaddress.Text;
                String port = txtportnumber.Text;

                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream , ProtocolType.Tcp);

                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse(ip), int.Parse(port));

                try
                {
                    sock.Connect(localEndPoint);
                    MessageBox.Show("Connection is OK");
                }

                catch(Exception ex)
                {
                    MessageBox.Show("Error please enter valid ip address and port number");
                }

                finally
                {
                    sock.Close();
                }
            }
            else
            {
                String ip = txtipaddress.Text;
                String port = txtportnumber.Text;
                String host = txthostname.Text;

                // I have to create here to conver the hostname to ip then i can use the socket to connect to remote 

                IPAddress[] ips;

                ips = Dns.GetHostAddresses(host);

                String x = ips.ToString();

                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPEndPoint IPEndPoint = new IPEndPoint(IPAddress.Parse(x), int.Parse(port));

                try
                {
                    sock.Connect(IPEndPoint);

                    MessageBox.Show("Connectino is OK");
                }

                catch( Exception ex)
                {
                    MessageBox.Show("Error , please enter valid ip address");

                }

                finally
                {
                    sock.Close();

                }
            }
        }

        private void txtportnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txthostname.Clear();
            txtipaddress.Clear();
            txtportnumber.Clear();
        }

        private void txthostname_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtportnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 5)
            {
                MessageBox.Show("Only Digit is allowed");
            }
        }
    }
}
