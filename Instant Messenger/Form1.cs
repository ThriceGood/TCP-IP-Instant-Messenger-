using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;


// code for instant messanger form


namespace Instant_Messenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // variables 
        // two integers for destination and host port number
        // two strings for destination and host IP address
        // one string for log save path
        //
        int destPort = 0;
        string destIP = "";
        int hostPort = 8080;
        string hostIP = "";
        string path = "";




        // method to set destination IP
        //
        public void set_destIP(string input)
        {
            destIP = input;
        }

        // method to set host IP
        //
        public void set_hostIP(string input)
        {
            hostIP = input;
        }

        // method to set dest port
        //
        public void set_destPort(int input)
        {
            destPort = input;
        }

        // method to set host port
        //
        public void set_hostPort(int input)
        {
            hostPort = input;
        }





        // method to start the listener background worker
        //
        public void startListner(bool input)
        {
            // starts the background worker if the input bool is true
            //
            if (input == true)
            {
                BGW_listener.RunWorkerAsync();
            }
        }






        // form load sets menu strip text colour to white
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;
        }




        // opens the connections form when user clicks File/Connections
        // passes this form into the connections form to allow the connection addresses to
        // be passed back to this form
        //
        private void connectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connections connect = new Connections(this);

            connect.ShowDialog();
        }





        // send button sends the users message
        // makes a TCP connection and sends the data/message through it
        // the message is the text in the message textbox
        // 
        private void btn_send_Click(object sender, EventArgs e)
        {
            // trys to run the code inside 'try', if it fails the crash is stoped
            // by the catch statement and an error message is displayed in a message box
            //
            try
            {
                TcpClient myTCPclient = new TcpClient();

                myTCPclient.Connect(destIP, destPort);


                NetworkStream myStream = myTCPclient.GetStream();

                byte[] data_in = Encoding.ASCII.GetBytes(textbox_message.Text);


                myStream.Write(data_in, 0, data_in.Length);


                textbox_recieve.Text += "\r\nSent :  " + textbox_message.Text;

                textbox_message.Clear();
            }
            catch
            {
                MessageBox.Show("Error: No connection made");
            }
        }



        // background worker for listener
        // the background worker allows the TCP listener loop to run without locking the main form
        // alse displays connection established message in the message recieval textbox
        //
        private void BGW_listener_DoWork(object sender, DoWorkEventArgs e)
        {
            // trys to start the listener, the catch statement stops it from crashing if the
            // IP address or port number is not found
            //
            try
            {
                // the invoke method allows cross thread communication
                //
                textbox_recieve.Invoke(new Action(() =>
                {
                    textbox_recieve.Text += "Connection established...";

                    textbox_recieve.Text += "\r\nDestination address :  " + destIP + " : " + destPort;

                    textbox_recieve.Text += "\r\nHost address :  " + hostIP + " : " + hostPort + "\r\n";
                }
                ));


                System.Net.IPAddress serverAddress = System.Net.IPAddress.Parse(hostIP);


                TcpListener myListener = new TcpListener(serverAddress, hostPort);
                myListener.Start();


                while (true)
                {
                    TcpClient myOtherTCPclient = myListener.AcceptTcpClient();

                    NetworkStream myOtherStream = myOtherTCPclient.GetStream();

                    byte[] data = new byte[myOtherTCPclient.ReceiveBufferSize];


                    // this code tries to print the recieved message to the recieved message textbox
                    // if the code fails because there is no message then the catch statement stops it from crashing
                    //
                    try
                    {
                        int bytes_read = myOtherStream.Read(data, 0, System.Convert.ToInt32(myOtherTCPclient.ReceiveBufferSize));

                        // the invoke method allows cross thread communication
                        //
                        textbox_recieve.Invoke(new Action(() =>
                        {
                            textbox_recieve.Text += ("\r\nRecieved :  " + Encoding.ASCII.GetString(data, 0, bytes_read));
                        }
                        ));
                    }
                    catch
                    {
                        // do nothing
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error: Address or port not found");
            }
             
        }



        // exits when user clicks on File/Exit
        //
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // opens the save file dialog box when the user clicks File/Save Log
        // user is only aloud to save .txt files
        //
        private void saveLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();


            save_dialog.Filter = "Notepad |* .txt";


            // if user clicks ok the .txt file is saved to their specified location
            //
            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter save_as = new StreamWriter(save_dialog.FileName);

                path = save_dialog.FileName;

                save_as.Write(textbox_recieve.Text);
                save_as.Close();
            }
        }











        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // not in use any more
        }

    }
}
