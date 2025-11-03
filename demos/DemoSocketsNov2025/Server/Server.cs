using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    public partial class Server : Form
    {
        private Socket? _lsok = null;
        private Socket? _csok = null;

        public Server()
        {
            InitializeComponent();
        }

        private void cbAcceptDone(IAsyncResult ar)
        {
            _csok = _lsok?.EndAccept(ar);
            Trace.WriteLine($"{_csok?.RemoteEndPoint}");
            Trace.WriteLine("Connection attempt here!");
            _lsok?.Close();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            _lsok = new Socket(
                AddressFamily.InterNetwork, // IP V4 address scheme
                SocketType.Stream,          // streaming socket (connection-based)
                ProtocolType.Tcp);          // TCP protocol

            try
            {
                _lsok.Bind(new IPEndPoint(IPAddress.Any, 1666));
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);

                // deal with reality
                return;
            }

            // Only one usage of each socket address (protocol/network address/port) is normally permitted.
            _lsok.Listen(5);

            _lsok.BeginAccept(cbAcceptDone, null);
        }

        private void UI_B_SendData_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[] { 1, 2, 42, 7 };
            _csok?.Send(data);
        }
    }
}
