using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandMode.Receiver;

namespace CommandMode.Command
{
    /// <summary>
    /// 熱炒訂單(ConcreteOrder)
    /// </summary>
    public class DishOrder : Order
    {
        public DishOrder(KitchenWorker receiver) : base(receiver)
        {
            base.name = "熱炒訂單";
        }
    }
}
