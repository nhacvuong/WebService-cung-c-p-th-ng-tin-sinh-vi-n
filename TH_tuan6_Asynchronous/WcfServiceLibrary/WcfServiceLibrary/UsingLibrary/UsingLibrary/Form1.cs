using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;
using UsingLibrary.ServiceLibrary;

namespace UsingLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        private void btn_http_Click(object sender, EventArgs e)
        {
            lb_stt.Text = "Server is computing, you can compute number here!";
            lb_stt.Update();
            ServiceLibrary.ServiceLibraryClient proxy = new ServiceLibrary.ServiceLibraryClient();
            proxy.GetAuthorCompleted += new EventHandler<ServiceLibrary.GetAuthorCompletedEventArgs>(callback);
            proxy.GetAuthorAsync();
        }
        void callback(object sender, ServiceLibrary.GetAuthorCompletedEventArgs e)
        {
            string rs = e.Result;
            label1.Text = rs;
            lb_stt.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
        }

        private void btn_getsync_Click(object sender, EventArgs e)
        {
            try
            {
                lb_stt.Text = "Server is computing, you can not compute number here!";
                lb_stt.Update();               
                ServiceLibrary.ServiceLibraryClient proxy = new ServiceLibrary.ServiceLibraryClient();
                string author = proxy.GetAuthor();
                label1.Text = " HTTP:" + author;
                lb_stt.Text = "";
                proxy.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }               
    }
}
