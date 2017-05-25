using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 银行案例
{
    class Program
    {
        static void Main(string[] args)
        {
  
            IBankAccount ba = new SaverAccoun("狗蛋");
            
            ba.Play(10000);//存款
            ba.PayOut(300);//取款
            Console.WriteLine(ba.ToString());

            Console.ReadKey();

        }
    }
}
