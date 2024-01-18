using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// нестатический класс
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// внутренние нестатические поля вещественного типа
        /// </summary>
        private double value1;
        private double value2;
        /// <summary>
        /// открытое целочисленное статическое поле
        /// </summary>
        public static int count;

        /// <summary>
        /// нестатический конструктор с двумя параметрами,
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        public MyClass (double value1, double value2)
        {
            this.value1=value1;
            this.value2 = value2;
            
        }
        /// <summary>
        /// нестатический конструктор без параметров
        /// </summary>
        public MyClass()
        {
            this.value1 = 2.0;
            this.value2 = 2.0;
            count++;
        }

        /// <summary>
        ///  статический конструктор
        /// </summary>
        static MyClass()
        {
            count = 0;
        }

        /// <summary>
        /// свойства для доступа к внутренним полям класса
        /// </summary>
        public double Value1
        {
            get { return value1; }
            set { value1 = value; }
        }

        public double Value2
        {
            get { return value2; }
            set { value2 = value; }
        }
        /// <summary>
        /// метод для вывода на экран внутренних полей класса.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Value1: " + value1);
            Console.WriteLine("Value2: " + value2);
        }

    }
}
