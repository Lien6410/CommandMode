using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMode.Receiver
{
    /// <summary>
    /// 酒保(ConcreteKitchenWorker)
    /// </summary>
    public class Bartender : KitchenWorker
    {
        /// <summary>
        /// Override
        /// </summary>
        public void FinishOrder()
        {
            Console.WriteLine("調酒，倒進杯子，飲料完成。");
            Console.WriteLine();
        }
    }
}
