using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class Client : Form
    {

        private Socket? _sok = null;

        private Stopwatch _sw = new Stopwatch();
        
        public Client()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbConnDone(IAsyncResult ar)
        {
            try
            {
                _sok?.EndConnect(ar);
                
                // T/C
                Invoke(new Action( () => Text = "We connected!"));
                Trace.WriteLine(_sw.ElapsedMilliseconds);
            }
            catch (Exception err)
            {
                Invoke(new Action(() => Text = "We !connected!"));
                Trace.WriteLine(err.Message);
                Trace.WriteLine(_sw.ElapsedMilliseconds);
            }
        }

        private void UI_B_COnnect_Click(object sender, EventArgs e)
        {
            // T/C
            _sok = new Socket(
                AddressFamily.InterNetwork, // IP V4 address scheme
                SocketType.Stream,          // streaming socket (connection-based)
                ProtocolType.Tcp);          // TCP protocol

            _sw.Restart();
            _sok.BeginConnect("localhost", 1666, cbConnDone, null);

        }
    }
}
