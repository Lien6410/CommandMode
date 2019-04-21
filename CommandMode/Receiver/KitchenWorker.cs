using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMode.Receiver
{
    /// <summary>
    /// 後台人員(Receiver)
    /// </summary>
    public interface KitchenWorker
    {
        /// <summary>
        /// 完成訂單
        /// </summary>
        void FinishOrder();
    }
}
