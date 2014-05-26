using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


// code for connections form



namespace Instant_Messenger
{
    public partial class Connections : Form
    {




        // creating an instance of Form1
        //
        Form1 mainForm;



        // constructor that takes in Form1 and stores it in 
        // the mainForm variable
        //
        public Connections(Form1 inputForm)
        {
            mainForm = inputForm;

            InitializeComponent(); 
        }



        // set button, sets the IP address and port number by calling set methods from Form1
        // and passing the text from the corresponding textboxes on the connections form
        // if there is a field missing from one of the textboxes then the error is stoped by the 
        // catch statement and a message box displays an error message to the user
        //
        private void btn_set_Click(object sender, EventArgs e)
        {
            try
            {
                mainForm.set_destIP(textbox_IPDest.Text);
                mainForm.set_destPort((int)Convert.ToInt32(textbox_PortDest.Text));

                mainForm.set_hostIP(textbox_IPHost.Text);
                mainForm.set_hostPort((int)Convert.ToInt32(textbox_PortHost.Text));

                mainForm.startListner(true);

                this.Close();
            }
            catch
            {
                MessageBox.Show("Error :  Fields missing");
            }

            
        }



        // cancel button closes this form
        //
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


      
    }
}
