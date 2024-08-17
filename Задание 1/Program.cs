using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Men man=new Men("Иванов",2000,"Москва");
            Console.WriteLine(man.Print());
            Student student=new Student("Иванов", 2000,"Москва","ИТМО");
            Console.WriteLine(student.Print());
            Console.ReadKey();
        }
    }
}
