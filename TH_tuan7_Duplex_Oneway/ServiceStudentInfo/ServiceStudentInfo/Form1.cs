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
using ServiceStudentInfo.StudentLib;
namespace ServiceStudentInfo
{
    public partial class Form1 : Form
    {
        
        private EndpointAddress address;

        private IStudentLib proxy;

        public Form1()
        {
            InitializeComponent();
        }

        public void show_student(StudentInfo si)
        {
            lb_mssv.Text = si.Id;
            lb_ht.Text = si.Name;
            lb_dc.Text = si.Address;
            lb_dt.Text = si.Phone;
            lb_em.Text = si.Email;
            lb_gt.Text = si.Sex;
            lb_k.Text = si.Faculty;
            lb_kh.Text = si.Course;
            lb_lo.Text = si._Class;
            lb_ng.Text = si.Major;
            lb_ns.Text = si.Birthday;
        }

        private int Check_gt(ComboBox cbb)
        {
            if (cbb.Text == "BasicHTTP")
                return 1;
            else if (cbb.Text == "NetTCP")
                return 2;
            else
                return 3;
        }

        private void Create_connection(ref EndpointAddress address, ref IStudentLib proxy)
        {
            if (Check_gt(cbb_gt) == 1)
            {
                address = new EndpointAddress("http://localhost:8707/StudentLib.svc");

                BasicHttpBinding binding = new BasicHttpBinding();

                proxy = ChannelFactory<IStudentLib>.CreateChannel(binding, address);

            }
            else if (Check_gt(cbb_gt) == 2)
            {
                address = new EndpointAddress("net.tcp://localhost:9001");

                NetTcpBinding binding = new NetTcpBinding();

                proxy = ChannelFactory<IStudentLib>.CreateChannel(binding, address);
            }
            else
            {
                address = new EndpointAddress("http://localhost:8000/StudentInfos1");

                WSHttpBinding binding = new WSHttpBinding();

                proxy = ChannelFactory<IStudentLib>.CreateChannel(binding, address);
            }           
    
        }

        private void btn_svhttp_Click(object sender, EventArgs e)
        {            

          Create_connection(ref address, ref proxy);            

          proxy.GetStudent_info(tb_mssv.Text);
                   
        }

        private void btn_async_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    lbstt.Text = "Server is computing, you can compute number here!";
            //    lbstt.Update();
            //    StudentInfos.ServiceStudentInfoClient proxy1 = new StudentInfos.ServiceStudentInfoClient();
            //    proxy1.GetStudent_infoCompleted += new EventHandler<StudentInfos.GetStudent_infoCompletedEventArgs>(callback);
            //    proxy1.GetStudent_infoAsync(tb_mssv.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        //void callback(object sender, StudentInfos.GetStudent_infoCompletedEventArgs e)
        //{
        //    //StudentInfo si = e.Result;
        //    //show_student(si);
        //    //lbstt.Text = "";
        //}

        private void btn_duplex_Click(object sender, EventArgs e)
        {
            // Construct InstanceContext to handle messages on callback interface
            InstanceContext instanceContext = new InstanceContext(new CallbackHandler());

            // Create a client
            StudentLibClient client = new StudentLibClient(instanceContext);

            client.GetStudent_info(tb_mssv.Text);           
        }

        //private void btn_svnettcp_Click(object sender, EventArgs e)
        //{
        //    EndpointAddress address = new EndpointAddress("net.tcp://localhost:9001");

        //    NetTcpBinding binding = new NetTcpBinding();

        //    IServiceStudentInfo proxy = ChannelFactory<IServiceStudentInfo>.CreateChannel(binding, address);

        //    StudentInfo si = new StudentInfo();

        //    si = proxy.GetStudent_info(tb_mssv.Text);
        //    if (si != null)
        //        show_student(si);
        //}

        //private void btn_svwshttp_Click(object sender, EventArgs e)
        //{
        //    EndpointAddress address = new EndpointAddress("http://localhost:8000/ServiceStudentInfo1");

        //    WSHttpBinding binding = new WSHttpBinding();

        //    IServiceStudentInfo proxy = ChannelFactory<IServiceStudentInfo>.CreateChannel(binding, address);

        //    StudentInfo si = new StudentInfo();

        //    si = proxy.GetStudent_info(tb_mssv.Text);
        //    if (si != null)
        //        show_student(si);
        //}
    }
}
