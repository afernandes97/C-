using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordenada<int> p;
            p.latitude = 10;
            p.longitude = 23;

            Coordenada<double> q;
            q.latitude = -46.34;
            q.longitude = -23.23;

        }
    }

    struct Coordenada<T>
    {
        internal T latitude;
        internal T longitude;
    }
}
