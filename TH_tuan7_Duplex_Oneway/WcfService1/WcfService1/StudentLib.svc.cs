using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WcfService1
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class StudentLib : IStudentLib
    {
        public void GetStudent_info(string id)
        {
            try
            {                
                StudentInfo si = new StudentInfo();

                Label[] lb = new Label[11];

                if (id == "080889")
                {
                    si.Id = "080889";
                    si.Name = "Tấn";
                    si.Sex = "Nam";
                    si.Faculty = "KHCN";
                    si.Major = "CNTT";
                    si.Training_system = "Cử nhân";
                    si.Birthday = "14/11/1990";
                    si._Class = "QL081";
                    si.Course = "2008";
                    si.Email = "tan.vq0889@hoasen.edu.vn";
                    si.Address = "abc";
                    si.Phone = "0000";
                    Callback.Show_student(si); 
                }
                else
                {
                    si = null;
                    MessageBox.Show("Không có sinh viên này");
                }
                               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        IStudentLibCallback Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<IStudentLibCallback>();
            }
        }
    }
}

