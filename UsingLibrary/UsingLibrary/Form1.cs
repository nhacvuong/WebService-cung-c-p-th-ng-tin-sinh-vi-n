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
using UsingLibrary.ServiceReference1;

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
            EndpointAddress address = new EndpointAddress("http://localhost:8000/ServiceLibrary");

            BasicHttpBinding binding = new BasicHttpBinding();

            IServiceLibrary proxy = ChannelFactory<IServiceLibrary>.CreateChannel(binding, address);
            string author = proxy.GetAuthor();
            label1.Text = " HTTP:" + author;
        }

        private void btn_wshttp_Click(object sender, EventArgs e)
        {
            EndpointAddress address = new EndpointAddress("http://localhost:8000/ServiceLibrary1");
            
            WSHttpBinding binding = new WSHttpBinding();

            IServiceLibrary proxy = ChannelFactory<IServiceLibrary>.CreateChannel(binding, address);
            string author = proxy.GetAuthor();
            label1.Text = " WSHTTP:" + author;
        }

        private void btn_nettcp_Click(object sender, EventArgs e)
        {
            EndpointAddress address = new EndpointAddress("net.tcp://localhost:9001");

            NetTcpBinding binding = new NetTcpBinding();

            IServiceLibrary proxy = ChannelFactory<IServiceLibrary>.CreateChannel(binding, address);
            string author = proxy.GetAuthor();
            label1.Text = " NETTCP:" + author;
        }
    }
}
