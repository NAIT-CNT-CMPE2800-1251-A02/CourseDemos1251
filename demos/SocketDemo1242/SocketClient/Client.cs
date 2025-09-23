﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace SocketClient
{
    public partial class Client : Form
    {
        Socket connectSocket = null;

        public Client()
        {
            InitializeComponent();
        }

        private async void UI_Connect_Btn_Click(object sender, EventArgs e)
        {
            connectSocket = new Socket(
                AddressFamily.InterNetwork, 
                SocketType.Stream,
                ProtocolType.Tcp);

            try
            {
                await connectSocket.ConnectAsync("localhost", 1666);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{nameof(UI_Connect_Btn_Click)} Connection could not be made: {ex.Message}");
            }
        }

        private void Send_Btn_Click(object sender, EventArgs e)
        {
            string phrase = "Hello, World!";

            byte[] bytes = Encoding.UTF8.GetBytes(phrase);

            connectSocket.Send(bytes);
        }

        private void Soft_Disco_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                connectSocket.Shutdown(SocketShutdown.Both);
            }
            catch (Exception ex)
            {
                // Class: Func. ex
            }
            finally
            {
                connectSocket.Close();

            }
        }
    }
}
