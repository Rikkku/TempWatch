using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerConnectionLibrary;

namespace TempCheck
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Set compatible text rendering default before creating any forms or controls
            Application.SetCompatibleTextRenderingDefault(false);

            // Connect to the server
            TcpClient client = null;
            try
            {
                ServerConnector serverConnector = new ServerConnector();
                if (!serverConnector.ConnectAndCheckStatus(out client))
                {
                    Console.WriteLine("Failed to connect to the server.");
                }
            }
            catch (Exception ex)
            {
                // Handle connection error
                Console.WriteLine("Error connecting to the server: " + ex.Message);
            }

            // Create an instance of Form1
            Form1 form = new Form1();

            // Set the label text based on connection status
            if (client != null && client.Connected)
            {
                form.ConnectCheckText = "Connected";
            }
            else
            {
                form.ConnectCheckText = "Not connected";
            }

            // Run the application with the modified form
            Application.EnableVisualStyles();
            Application.Run(form);
        }
    }
}
