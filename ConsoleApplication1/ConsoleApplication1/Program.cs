using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int u;
            Console.WriteLine("Введите число");
            u = Convert.ToInt32(Console.ReadLine());
            if (u > 0) { u = u * 2; Console.WriteLine("Число положительное, увеличиваем в 2 раза"); }
            else if (u < 0) { u = u - 3; Console.WriteLine("Число отрицательное, уменьшаем на 3"); }
            else { u = 10; Console.WriteLine("Замена на 10"); }
            Console.WriteLine("Результат: " + u);
            Console.ReadLine();
        }
    }
}
