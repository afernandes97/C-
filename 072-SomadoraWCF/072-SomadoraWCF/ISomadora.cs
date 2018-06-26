using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _072_SomadoraWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISomadora" in both code and config file together.
    [ServiceContract]
    public interface ISomadora
    {
        [OperationContract]
        int Somar(int x, int y);
    }
}
