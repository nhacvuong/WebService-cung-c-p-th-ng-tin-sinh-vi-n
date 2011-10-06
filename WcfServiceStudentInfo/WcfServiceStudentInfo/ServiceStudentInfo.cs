using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

namespace WcfServiceStudentInfo
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in App.config.
    public class ServiceStudentInfo : IServiceStudentInfo
    {
        public StudentInfo GetStudent_info(string id)
        {
            try
            {
                StudentInfo si = new StudentInfo();
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
                }
                else
                {
                    si = null;
                }
                return si;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }       
    }
}
