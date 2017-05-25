using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._25_lx
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane ap = new Airplane("飞行工具","济宁号","白色",2000);
            Console.WriteLine(ap);

            Bird bird = new Bird("鸟类","黄色");
            bird.BirdName = "黄鹂鸟";
            bird.Sex = "母";
            Console.WriteLine("{0},{1},{2},",bird.GetShow(),bird.BirdName,bird.Sex);



            Console.ReadKey();
        }
    }
}
