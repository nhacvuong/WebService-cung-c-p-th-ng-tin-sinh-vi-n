using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WcfServiceLibrary
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in App.config.
    public class ServiceLibrary : IServiceLibrary
    {        
        public string GetAuthor()
        {
            string author = "tac gia ng van a ";
            string topic = "de tai văn học";
            Thread.Sleep(10000);
            return author + topic;
        } 

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
