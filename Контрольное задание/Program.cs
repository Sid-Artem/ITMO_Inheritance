using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Контрольное_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building Building = new Building("Москва",50,100,10);
            Console.WriteLine(Building.Print());
            MultiBulding MultiBulding = new MultiBulding("Москва", 50, 100, 10,6);
            Console.WriteLine(MultiBulding.Print());
            Console.ReadKey();

        }
    }
}
