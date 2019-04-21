using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandMode.Receiver;

namespace CommandMode.Command
{
    /// <summary>
    /// 訂單(Command)
    /// </summary>
    public abstract class Order
    {
        // 後台人員(Receiver)
        protected KitchenWorker receiver;
        protected string name;

        public Order(KitchenWorker receiver)
        {
            this.receiver = receiver;
        }

        /// <summary>
        /// 將訂單送給廚房人員
        /// </summary>
        public void SendOrder()
        {
            receiver.FinishOrder();
        }

        /// <summary>
        /// 讓其他程式知道這是甚麼訂單
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }
    }
}
