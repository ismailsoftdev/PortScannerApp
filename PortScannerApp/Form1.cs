using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace PortScannerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the Scan button click event.
        /// </summary>
        private void ScanButton_Click(object sender, EventArgs e)
        {
            // Extract the port range from the text box
            string[] portRange = txtBoxPorts.Text.Trim().Split('-');

            // Check if the port range format is valid
            if (portRange.Length != 2)
            {
                MessageBox.Show("Invalid port range format. Please use 'startPort-endPort' format.");
                return;
            }

            // Parse start and end ports
            if (!int.TryParse(portRange[0], out int startPort) || !int.TryParse(portRange[1], out int endPort))
            {
                MessageBox.Show("Invalid port range. Please enter valid port numbers.");
                return;
            }

            // Clear previous results
            scannedPortsListBox.Items.Clear();

            // Check if start port is less than or equal to end port
            if (startPort > endPort)
            {
                MessageBox.Show("Start port must be less than or equal to end port.");
                return;
            }

            // Run port scanning operation asynchronously
            Task.Run(() =>
            {
                string ipAddress = "127.0.0.1"; // Localhost IP address
                for (int port = startPort; port <= endPort; port++)
                {
                    string result;
                    using (TcpClient tcpClient = new TcpClient())
                    {
                        try
                        {
                            // Attempt to connect to the port
                            tcpClient.Connect(ipAddress, port);
                            result = $"Port {port} is open on {ipAddress}\n";
                            tcpClient.Connect("localhost", port);
                            result += $"Port {port} is open on localhost\n";
                        }
                        catch (SocketException)
                        {
                            result = $"Port {port} is closed or unreachable on {ipAddress}";
                            result += $"Port {port} is closed or unreachable on localhost";
                        }
                    }
                    // Add result to the list box on the UI thread
                    scannedPortsListBox.Invoke((Action)(() => scannedPortsListBox.Items.Add(result)));
                }

                // Show completion message after scanning is done
                MessageBox.Show("Scan completed. Please see the results in the Scanned Ports list box.");
            });
        }
    }
}
