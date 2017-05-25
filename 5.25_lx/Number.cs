using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._25_lx
{
    class Number : Inumber
    {
        private int myx;
        public int x;

        int Inumber.x
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public Number(int x) {
            this.x = x;
        }
        
       

        public void ShowInfo()
        {
            Console.WriteLine("hahahah");
        }
    }
}
