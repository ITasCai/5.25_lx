using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._25_lx
{
    class Bird : Animal,Ifly
    {

        public Bird() {
        }

        public Bird(string TypeName,string Color):base(TypeName) {
            this.Color = Color;
        }

        public String BirdName { set; get; }
        public string Color { set; get; }

        public string Sex { set; get; }
       


        public override void EatFood()
        {
            Console.WriteLine("鸟吃屎!");
        }
        public void SingSong() {
            Console.WriteLine("小小鸟！");
        }
        public string GetShow() {
            String name = TypeName;
            return name;
        }

        public void Takeoff()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Land()
        {
            throw new NotImplementedException();
        }
    }
}
