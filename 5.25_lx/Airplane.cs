using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._25_lx
{
    /// <summary>
    /// 飞机类
    /// </summary>
    class Airplane:Vehicle,Ifly
    {
        //private int vehicleNo;

        private string name;
        private string color;
        private double speed;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public double Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        /// <summary>
        /// 飞机的构造函数
        /// </summary>
        /// <param name="typeName">类别名称</param>
        /// <param name="name">飞机名称</param>
        /// <param name="color">颜色</param>
        /// <param name="speed">速度</param>
        public Airplane(string TypeName, string name,string color,double speed):base(TypeName) {
         
            this.name = name;
            this.color = color;
            this.speed = speed;
        }

        /// <summary>
        /// 重写了父类的载客方法
        /// </summary>
        public override void Passenger()
        {
            Console.WriteLine("大济宁号飞机载了55人!!!!");
        }


        public void PlusOil() {
            Console.WriteLine("飞机空中加油!!");
        }

        public override string ToString()
        {
            return "工具的类别：" + Type + "名称：" + name + "颜色：" + color + "时速：" + speed;
        }



        
        public void Takeoff()
        {
            Console.WriteLine("飞机起飞");
        }

        public void Fly()
        {
            Console.WriteLine("飞机飞翔");
        }

        public void Land()
        {
            Console.WriteLine("飞机着陆");
        }
    }
}
