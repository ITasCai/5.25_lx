using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 银行案例
{
    class GoldAccount : IBankAccount
    {
        private string AccountName { set; get; }

        public GoldAccount(string accountName)
        {
            this.AccountName = accountName;
        }
        private decimal balance;


        /// <summary>
        /// 
        /// </summary>
        public decimal Balance
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// 取款
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool PayOut(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine(AccountName + "取款成功：" + amount);
                return true;
            }
            Console.WriteLine("取款失败");
            return false;
        }

        /// <summary>
        /// 存款
        /// </summary>
        /// <param name="amount"></param>
        public void Play(decimal amount)
        {
            balance = balance + amount;
        }

        /// <summary>
        /// 查看账户余额
        /// </summary>
        /// <returns>返回余额</returns>
        public override string ToString()
        {
            return string.Format("余额：{0,c:2}", balance);
        }

        public void VIP() {
            Console.WriteLine("我就是VIP!");
        }

        public string OpendAccount()
        {
            throw new NotImplementedException();
        }
    }
}
