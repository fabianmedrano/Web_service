using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary
{
    [ServiceContract]
    public interface IServiceRandom
    {
        [OperationContract]
         string GetRandom();
    }
}
