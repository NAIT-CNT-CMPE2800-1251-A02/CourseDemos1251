using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Client
{
    public partial class Client : Form
    {
        private Thread? _rxdata = null;

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
                Invoke(new Action(() => Text = "We connected!"));
                Trace.WriteLine(_sw.ElapsedMilliseconds);

                // start rx thread
                _rxdata = new Thread(new ThreadStart(TRXBody));
                _rxdata.IsBackground = true;
                _rxdata.Start();
            }
            catch (Exception err)
            {
                Invoke(new Action(() => Text = "We !connected!"));
                Trace.WriteLine(err.Message);
                Trace.WriteLine(_sw.ElapsedMilliseconds);
            }
        }

        private void TRXBody()
        {
            while (true)
            {
                byte[] buff = new byte[1024];
                try
                {
                    int? iRxCount = _sok?.Receive(buff);

                    // this is soft disco
                    if (iRxCount == 0)
                    {
                        Trace.WriteLine("soft disco!");
                        return;
                    }

                    // this is good data!
                    for (int i = 0; i < iRxCount; ++i)
                    {
                        Trace.WriteLine($"data -> {buff[i]}");
                    }
                }
                catch (Exception err)
                {
                    // this is hard disco
                    // An existing connection was forcibly closed by the remote host.
                    Trace.WriteLine(err.Message);
                    return;
                }
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

        private void UI_B_Disco_Click(object sender, EventArgs e)
        {
            // An established connection was aborted by the software in your host machine.
            // t/c
            _sok?.Shutdown(SocketShutdown.Both);

            // t/c
            _sok?.Close();
        }
    }
}
