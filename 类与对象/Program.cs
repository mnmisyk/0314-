using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类与对象
{
    class Program
    {
        static void Main(string[] args)
        {
            Person SunQuan = new Person();
            SunQuan.name = "SunQuan";
            SunQuan.Age = -23;
            SunQuan.CHLSS();
            Console.WriteLine("ppp{0}",SunQuan.Age);
            Console.ReadLine();
        }
    }
}
