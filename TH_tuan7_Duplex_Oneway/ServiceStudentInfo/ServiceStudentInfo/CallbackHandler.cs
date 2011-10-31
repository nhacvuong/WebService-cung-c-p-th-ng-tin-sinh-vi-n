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
    public class CallbackHandler:IStudentLibCallback
    {        
        public void Show_student(StudentInfo si)
        {
            Form2 frm = new Form2();
            frm.lb_mssv.Text = si.Id;
            frm.lb_ht.Text = si.Name;
            frm.lb_dc.Text = si.Address;
            frm.lb_dt.Text = si.Phone;
            frm.lb_em.Text = si.Email;
            frm.lb_gt.Text = si.Sex;
            frm.lb_k.Text = si.Faculty;
            frm.lb_kh.Text = si.Course;
            frm.lb_lo.Text = si._Class;
            frm.lb_ng.Text = si.Major;
            frm.lb_ns.Text = si.Birthday;
            frm.ShowDialog();
        }
    }
}
