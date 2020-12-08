using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSOVA_24
{
    class Car
    {
        public string Mark;

        //0 - lightweight | 1 - truck
        public int CarType;

        public int Power;

        public int FuelPerKm;

        public int FuelTankSize;

        public bool isEmpty = true;


        public Car()
        {
            Mark = ""; CarType = -1; Power = 0; FuelPerKm = 0; FuelTankSize = 0;
        }

        public Car(Car a)
        {
            Mark = a.Mark; CarType = a.CarType; Power = a.Power; FuelPerKm = a.FuelPerKm; FuelTankSize = a.FuelTankSize;
            isEmpty = false;
        }

        public Car(string Mark_p, int CarType_p, int Power_p, int FuelPerKm_p, int FuelTankSize_p)
        {
            Mark = Mark_p; CarType = CarType_p; Power = Power_p; FuelPerKm = FuelPerKm_p; FuelTankSize = FuelTankSize_p;
            isEmpty = false;
        }
    }
}
