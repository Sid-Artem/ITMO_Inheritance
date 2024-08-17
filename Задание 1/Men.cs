using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Men
    {
        string name;
        int bithdayDate;
        string city;

        public Men(string name, int bithdayDate, string city)
        {
            this.name = name;
            this.bithdayDate = bithdayDate;
            this.city = city;
        }
        public string Print()
        {
            return $"{name} {bithdayDate} {city}";

        }
    }
}
