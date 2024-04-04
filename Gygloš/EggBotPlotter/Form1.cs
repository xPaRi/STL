using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggBotPlotter
{
    /// <summary>
    /// http://www.root.cz/clanky/vektorovy-graficky-format-hpgl/
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (Properties.Settings.Default.UpgradeRequired)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpgradeRequired = false;
                Properties.Settings.Default.Save();
            }
        }

        private int Port
        {
            get 
            {
                int port;

                if (!Int32.TryParse(texPort.Text.Trim(), out port))
                    port = 80;

                return port;
            }
        }

        private int Step
        {
            get 
            {
                return (int)texStep.Value;
            }
        }

        private void Send(string hostname, int port, string[] commandList)
        {
            try
            {
                using (TcpClient client = new TcpClient(hostname, port))
                {
                    using (NetworkStream stream = client.GetStream())
                    {


                        foreach (string command in commandList)
                        {
                            //log
                            texCommunication.AppendText(String.Format("> {0}\t", command));

                            var responseData = SendAndReceive(stream, command);

                            //log
                            texCommunication.AppendText(String.Format("{0}\r\n", responseData));
                        }

                        Thread.Sleep(10);

                        SendAndReceive(stream, "END");

                        // Close everything.
                        stream.Close();
                    }
                    client.Close();
                }
            }
            catch (Exception ex)
            {
                texCommunication.AppendText(String.Format("{0}\r\n", ex.Message));
            }
        }

        private string SendAndReceive(NetworkStream stream, string command)
        {
            // Send the message to the connected TcpServer. 
            var data = System.Text.Encoding.UTF8.GetBytes(command);
            stream.Write(data, 0, data.Length);

            // Response data
            data = new byte[256]; // Buffer to store the response bytes.

            // Read the first batch of the TcpServer response bytes.
            var bytes = stream.Read(data, 0, data.Length);
            var responseData = Encoding.UTF8.GetString(data, 0, bytes);

            return responseData;
        }

        private void SendSimpleCommand(string command)
        {
            this.Cursor = Cursors.WaitCursor;
            
            Send(texHostname.Text.Trim(), Port, new string[] { command });

            this.Cursor = Cursors.Default;
        }

        private void butSend_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Send(texHostname.Text.Trim(), Port, (texInitString.Text.Trim() + ";" + texCommandList.Text).Split(new char[] {';','\n', '\r'}, StringSplitOptions.RemoveEmptyEntries));

            this.Cursor = Cursors.Default;
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "HP Graphics Language file (*.hpgl)|*.hpgl",
                FileName = Properties.Settings.Default.FileName
            };

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.FileName = dialog.FileName;
                Properties.Settings.Default.Save();

                try
                {
                    var temp = System.IO.File.ReadAllText(dialog.FileName);

                    texCommandList.AppendText(temp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void butClear_Click(object sender, EventArgs e)
        {
            texCommunication.Clear();
        }

        private void butOpenLast_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = System.IO.File.ReadAllText(Properties.Settings.Default.FileName);

                texCommandList.AppendText(temp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butUp_Click(object sender, EventArgs e)
        {
            SendSimpleCommand(String.Format("PR0,{0}", Step));
        }

        private void butDown_Click(object sender, EventArgs e)
        {
            SendSimpleCommand(String.Format("PR0,-{0}", Step));
        }

        private void butTurnLeft_Click(object sender, EventArgs e)
        {
            SendSimpleCommand(String.Format("PR-{0},0", Step));
        }

        private void butTurnRight_Click(object sender, EventArgs e)
        {
            SendSimpleCommand(String.Format("PR{0},0", Step));
        }

        private void butPenUp_Click(object sender, EventArgs e)
        {
            SendSimpleCommand("PU");
        }

        private void butPenDown_Click(object sender, EventArgs e)
        {
            SendSimpleCommand("PD");
        }
    }
}
