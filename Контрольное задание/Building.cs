using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Контрольное_задание
{
   class Building
    {
        string adress;
        double length;
        double width;
        double height;

        public double Length
        {
            get
            {
                return length;

            }
            set
            {
                length = value ;
            }
        }
       

        public double Width
        {
            get
            {
                return width;

            }
            set
            {
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;

            }
            set
            {
                height = value;
            }
        }

        public string Adress
        {
            get
            {
                return adress;

            }
            set
            {
                adress = value;
            }
        }


        public Building(string adress, double length, double width, double height)
        {
            this.Adress = adress;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        
        }
        public string Print()
        {
            return $"{adress},{length},{width},{height}";
        }


    }
}
