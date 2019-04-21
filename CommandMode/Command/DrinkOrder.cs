using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandMode.Receiver;

namespace CommandMode.Command
{
    /// <summary>
    /// 飲料訂單(ConcreteOrder)
    /// </summary>
    public class DrinkOrder : Order
    {
        public DrinkOrder(KitchenWorker receiver) : base(receiver)
        {
            base.name = "飲料訂單";
        }
    }
}
