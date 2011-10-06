using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceStudentInfo
{
    // NOTE: If you change the interface name "IService1" here, you must also update the reference to "IService1" in App.config.
    [ServiceContract]
    public interface IServiceStudentInfo
    {
        [OperationContract]
        StudentInfo GetStudent_info(string id);        

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations
    [DataContract]
    public class StudentInfo
    {
        string id = "";
        string name = "";
        string birthday = "";
        string faculty = "";
        string major = "";
        string sex = "";
        string _class = "";
        string training_system = "";
        string course = "";
        string phone = "";
        string email = "";
        string address = "";
        [DataMember]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        [DataMember]
        public string _Class
        {
            get { return _class; }
            set { _class = value; }
        }
        [DataMember]
        public string Major
        {
            get { return major; }
            set { major = value; }
        }
        [DataMember]
        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }
        [DataMember]
        public string Course
        {
            get { return course; }
            set { course = value; }
        }
        [DataMember]
        public string Training_system
        {
            get { return training_system; }
            set { training_system = value; }
        }
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [DataMember]
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        [DataMember]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        [DataMember]
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

    }    
}
