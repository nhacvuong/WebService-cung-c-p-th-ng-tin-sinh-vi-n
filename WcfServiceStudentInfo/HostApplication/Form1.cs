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


namespace HostApplication
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
            
        }


        private int test(ComboBox cmb)
        {
            if (cmb.SelectedItem.ToString() == "Basic http")
                return 1;
            else if (cmb.SelectedItem.ToString() == "net tcp")
                return 2;
            else if (cmb.SelectedItem.ToString() == "ws http")
                return 3;
            else return 0;
        }


        private void bt_start_Click(object sender, EventArgs e)
        {
            
            /*
             //Uri baseAddress = new Uri("net.tcp://localhost:9001");   // tcp dung cho local network
             * Neu dung host voi baseAddress net.tcp thi khong the thuc hien cac dong lenh {(1), (2), (3)}
             * vi nhung dong lenh nay dung giao thuc http (internet)
             * */
            Uri baseAddress = new Uri(tb_ba.Text);

            Type contractType = typeof(WcfServiceStudentInfo.IServiceStudentInfo);
            Type instanceType = typeof(WcfServiceStudentInfo.ServiceStudentInfo);

            ServiceHost host = new ServiceHost(instanceType, baseAddress);

            CheckBox[] chb = new CheckBox[3] { checkBox1, checkBox2, checkBox3 };
            ComboBox[] cmb = new ComboBox[3] { cb_1, cb_2, cb_3 };

            string relativeAddress = "ServiceStudentInfo";
                for (int i = 0; i < 3; i++)
                {
                    if (chb[i].Checked == true)
                    {
                        if (test(cmb[i]) == 1)
                            host.AddServiceEndpoint(contractType, new BasicHttpBinding(), relativeAddress);
                        else if (test(cmb[i]) == 2)
                        {
                            NetTcpBinding A = new NetTcpBinding(SecurityMode.Transport);
                            host.AddServiceEndpoint(contractType, new NetTcpBinding(), "net.tcp://localhost:9000");
                            host.AddServiceEndpoint(contractType, A, "net.tcp://localhost:9001");
                        }
                        else if (test(cmb[i]) == 3)
                        {
                            string relativeAddress1 = "ServiceStudentInfo1";
                            host.AddServiceEndpoint(contractType, new WSHttpBinding(), relativeAddress1);
                        }
                        else
                            continue;
                    }
                }  
                 
                if (chb_showmex.Checked == true)
                {
                    // Add behavior for our MEX endpoint
                    ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                    behavior.HttpGetEnabled = true;                    
                    host.Description.Behaviors.Add(behavior); //(2)
                    // Add MEX endpoint at http://localhost:8080/MEX/
                    host.AddServiceEndpoint(typeof(IMetadataExchange), new BasicHttpBinding(), "MEX");  // (3)      
                    host.AddServiceEndpoint(typeof(IMetadataExchange), new NetTcpBinding(), "net.tcp://localhost:9001/MEX");
                }
                host.Open();                
            
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            Uri baseAddress = new Uri(tb_ba.Text);

            Type contractType = typeof(WcfServiceStudentInfo.IServiceStudentInfo);
            Type instanceType = typeof(WcfServiceStudentInfo.ServiceStudentInfo);
            ServiceHost host = new ServiceHost(instanceType, baseAddress);
            host.Close();
        }       
    }
}
