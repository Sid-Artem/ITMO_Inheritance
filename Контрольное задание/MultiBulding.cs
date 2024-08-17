using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Контрольное_задание
{
    sealed class MultiBulding:Building
    {
        double numberOfFloors;

        public double NumberOfFloors
        {
            get
            {
                return numberOfFloors;

            }
            set
            {
                numberOfFloors = value;
            }
        }

        public MultiBulding (string adress, double length, double width, double height, double numberOfFloors)
            :base(adress, length, width, height)
        {
            this.NumberOfFloors = numberOfFloors;
        }

        public string Print()
        {
            string result= base.Print();
            string final= $"{result},{numberOfFloors}";
            return final;

        }
    }
   



}
