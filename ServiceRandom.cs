using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary
{

    public class ServiceRandom :IServiceRandom
    {
     
        public string GetRandom()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 101);
            return string.Format("Your random Number: {0}", randomNumber);
        }
    }
}
