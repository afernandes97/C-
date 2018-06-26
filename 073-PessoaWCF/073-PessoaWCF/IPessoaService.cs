using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _073_PessoaWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPessoaService" in both code and config file together.
    [ServiceContract]
    public interface IPessoaService
    {
        [OperationContract]
        IEnumerable<Pessoa> Get();
    }
}
