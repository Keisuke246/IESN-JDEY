using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class Car
    {
        public String PlateNumber { get; set; }
        public Car(String plateNumber)
        {
            PlateNumber = plateNumber;
        }
        public String ToString()
        {
            return "Plaque : " + PlateNumber;
        }
    }
}
