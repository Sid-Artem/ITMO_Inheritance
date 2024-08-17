using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Student : Men
    {
        string university;

        public Student(string name, int bithdayDate, string city, string university)



            : base(name, bithdayDate, city)
        {
            this.university = university;
        }

        public string Print()

        {
            string result= base.Print();
            result += $"{university}";
            return result;
        }
           


        




    }
}
