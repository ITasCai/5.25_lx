using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._25_lx
{
  abstract  class Animal
    {
        /// <summary>
        /// 动物类别
        /// </summary>
        protected string TypeName;


        public Animal() {
        }
        public Animal(string typeName)
        {
            this.TypeName = typeName;
        }

        public void Cal() {
            Console.WriteLine("嗷嗷嗷嗷叫！！");
        }
        public void Sheep() {
            Console.WriteLine("呼呼呼呼睡！！");
        }

        public abstract void EatFood();
    }
}
