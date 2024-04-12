using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerConnectionLibrary;

namespace TempCheck
{
    public partial class Form1 : Form
    {
        private TcpClient client;

        public Form1()
        {
            InitializeComponent();
            InitializeForm(); // Initialize the form components and connect to the server
        }

        private async void InitializeForm()
        {
            try
            {
                // Connect to the server when the form is created
                await ConnectToServerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to server: " + ex.Message);
            }
        }

        private async Task ConnectToServerAsync()
        {
            ServerConnector connector = new ServerConnector();
            if (connector.ConnectAndCheckStatus(out client)) // Connect to server using ServerConnector
            {
                ConnectCheckText = "Connected"; // Update UI to indicate connection status

                // Start background task to continuously receive messages from server
                Task.Run(async () => await ReceiveMessagesFromServerAsync());
            }
            else
            {
                MessageBox.Show("Failed to connect to the server.");
            }
        }

        private async Task ReceiveMessagesFromServerAsync()
        {
            try
            {
                while (client.Connected) // Continue receiving messages as long as the client is connected
                {
                    if (client.GetStream().DataAvailable)
                    {
                        NetworkStream stream = client.GetStream();
                        byte[] buffer = new byte[1024];
                        int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length); // Read message from server asynchronously
                        string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                        // Handle received message (if needed)
                        // For example, you can update UI or perform other actions based on the received message
                    }
                    else
                    {
                        await Task.Delay(100); // Wait for 100 milliseconds before checking again
                    }
                }
            }
            catch (Exception ex)
            {
                // Only show the error message if it's not due to the client being disposed
                if (!(ex is ObjectDisposedException))
                {
                    MessageBox.Show("Error receiving message from server: " + ex.Message);
                }
            }
        }

        private async void LogoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Close the existing client connection
                if (client != null && client.Connected)
                {
                    client.Close();
                    client.Dispose();

                    // Make register box invisible with the button
                    this.RegUserBox.Visible = false;
                    this.RegPassBox.Visible = false;
                    this.RegPass2Box.Visible = false;
                    this.RegisterButton.Visible = false;
                    this.LogoutButton.Visible = false;

                    // Make login box visible with the button
                    this.LoginUserBox.Visible = true;
                    this.LoginPasswordBox.Visible = true;
                    this.LoginButton.Visible = true;
                    this.LoginLabel.Visible = true;
                    this.RegisterLabel.Visible = true;
                }

                // Connect to the server again
                await ConnectToServerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging out: " + ex.Message);
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = RegUserBox.Text;
            string password = RegPassBox.Text;
            string confirmPassword = RegPass2Box.Text;

            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Send registration request to server
            string message = $"register:{username}:{password}";
            SendMessageToServer(message);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = LoginUserBox.Text;
            string password = LoginPasswordBox.Text;

            // Send login request to server
            string message = $"login:{username}:{password}";
            SendMessageToServer(message);
        }

        private async void SendMessageToServer(string message)
        {
            try
            {
                if (client != null && client.Connected)
                {
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    NetworkStream stream = client.GetStream();
                    await stream.WriteAsync(data, 0, data.Length); // Write message to the server asynchronously

                    // Read server response
                    byte[] responseBuffer = new byte[1024];
                    int bytesRead = await stream.ReadAsync(responseBuffer, 0, responseBuffer.Length);
                    string response = Encoding.ASCII.GetString(responseBuffer, 0, bytesRead);

                    if (response.StartsWith("Invalid")) // Check if the response indicates an error
                    {
                        MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        client.Close(); // Close the existing client connection
                        await ConnectToServerAsync(); // Reconnect to the server
                    }
                    else if (response.StartsWith("Login successful"))
                    {
                        MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Handle successful login here, if needed
                        // Make the Login box and button invisible
                        this.LoginUserBox.Visible = false;
                        this.LoginPasswordBox.Visible = false;
                        this.LoginButton.Visible = false;
                        this.LoginButton.Visible = false;
                        this.LogoutButton.Visible = true;
                        this.LoginLabel.Visible = false;
                        this.RegisterLabel.Visible = false;
                    }
                    else if (response.StartsWith("Username already exists"))
                    {
                        MessageBox.Show("Username already exists. Please choose a different one.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (response.StartsWith("Registration successful"))
                    {
                        // Handle successful registration here, if needed
                        MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reconnect to the server to keep the connection alive
                        await ConnectToServerAsync();

                        // Make register box invisible with the button
                        this.RegUserBox.Visible = false;
                        this.RegPassBox.Visible = false;
                        this.RegPass2Box.Visible = false;
                        this.RegisterButton.Visible = false;

                        // Make login box visible with the button
                        this.LoginUserBox.Visible = true;
                        this.LoginPasswordBox.Visible = true;
                        this.LoginButton.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Not connected to server.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error communicating with server: " + ex.Message);
            }
        }




        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            // Make register box visible with the button
            this.RegUserBox.Visible = true;
            this.RegPassBox.Visible = true;
            this.RegPass2Box.Visible = true;
            this.RegisterButton.Visible = true;

            // Make login box invisible with the button
            this.LoginUserBox.Visible = false;
            this.LoginPasswordBox.Visible = false;
            this.LoginButton.Visible = false;
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            // Make register box invisible with the button
            this.RegUserBox.Visible = false;
            this.RegPassBox.Visible = false;
            this.RegPass2Box.Visible = false;
            this.RegisterButton.Visible = false;

            // Make login box visible with the button
            this.LoginUserBox.Visible = true;
            this.LoginPasswordBox.Visible = true;
            this.LoginButton.Visible = true;
        }


        public string ConnectCheckText
        {
            get { return ConnectCheck.Text; }
            set { ConnectCheck.Text = value; }
        }
    }
}
