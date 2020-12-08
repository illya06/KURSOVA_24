using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSOVA_24
{
    class Lightweight
    {
        public int CarType;
        Lightweight()
        {
            CarType = 0;
        }
        Lightweight(Lightweight a)
        {
            CarType = a.CarType;
        }
        Lightweight(int CarType_p)
        {
            CarType = CarType_p;
        }
        
    }
}
