using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MyClass myClass1 = new MyClass();

            Console.WriteLine("количества созданных экземпляров: " + MyClass.count);

            
            myClass1.Print();
            Console.ReadKey();
        }
    }
}
