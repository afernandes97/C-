using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _072_SomadoraWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Somadora" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Somadora.svc or Somadora.svc.cs at the Solution Explorer and start debugging.
    public class Somadora : ISomadora
    {
        public int Somar(int x, int y)
        {
            return x + y;
        }
    }
}
