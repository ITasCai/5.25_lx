using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._25_lx
{
    /// <summary>
    /// 交通工具类：基类
    /// </summary>
    class Vehicle
    {

        /// <summary>
        /// 交通工具分类
        /// </summary>

        private string type;

       
        public Vehicle(string type)
        {
            this.type = type;
        }

        /// <summary>
        /// 体积或者重量
        /// </summary>
        public double Weight { get; set; }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public Vehicle() {

        }


 

        /// <summary>
        /// 载客
        /// </summary>
        public virtual void Passenger() {
            Console.WriteLine("载客");
        }
    }
}
