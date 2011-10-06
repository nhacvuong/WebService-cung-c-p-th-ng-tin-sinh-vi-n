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
using ServiceStudentInfo.ServiceReference1;

namespace ServiceStudentInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void show_student(StudentInfo si)
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

        private void btn_svhttp_Click(object sender, EventArgs e)
        {
            EndpointAddress address = new EndpointAddress("http://localhost:8000/ServiceStudentInfo");

            BasicHttpBinding binding = new BasicHttpBinding();

            IServiceStudentInfo proxy = ChannelFactory<IServiceStudentInfo>.CreateChannel(binding, address);

            StudentInfo si = new StudentInfo();

            si = proxy.GetStudent_info(tb_mssv.Text);
            if(si!=null)
                show_student(si);        
        }

        private void btn_svnettcp_Click(object sender, EventArgs e)
        {
            EndpointAddress address = new EndpointAddress("net.tcp://localhost:9001");

            NetTcpBinding binding = new NetTcpBinding();

            IServiceStudentInfo proxy = ChannelFactory<IServiceStudentInfo>.CreateChannel(binding, address);

            StudentInfo si = new StudentInfo();

            si = proxy.GetStudent_info(tb_mssv.Text);
            if (si != null)
                show_student(si);       
        }

        private void btn_svwshttp_Click(object sender, EventArgs e)
        {
            EndpointAddress address = new EndpointAddress("http://localhost:8000/ServiceStudentInfo1");

            WSHttpBinding binding = new WSHttpBinding();

            IServiceStudentInfo proxy = ChannelFactory<IServiceStudentInfo>.CreateChannel(binding, address);

            StudentInfo si = new StudentInfo();

            si = proxy.GetStudent_info(tb_mssv.Text);
            if (si != null)
                show_student(si); 
        }
    }
}
