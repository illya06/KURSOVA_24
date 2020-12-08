using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSOVA_24
{
    class Truck: Car
    {
        public int CarType;
        Truck()
        {
            CarType = 1;
        }
        Truck(Truck a)
        {
            CarType = a.CarType;
        }
        Truck(int CarType_p)
        {
            CarType = CarType_p;
        }
    }
}
