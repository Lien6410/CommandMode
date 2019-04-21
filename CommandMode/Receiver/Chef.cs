using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMode.Receiver
{
    /// <summary>
    /// 大廚(ConcreteKitchenWorker)
    /// </summary>
    public class Chef : KitchenWorker
    {
        /// <summary>
        /// Override
        /// </summary>
        public void FinishOrder()
        {
            Console.WriteLine("備料，大火快炒，上菜。");
            Console.WriteLine();
        }
    }
}
