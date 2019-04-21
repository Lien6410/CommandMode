using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandMode.Command;
using CommandMode.Receiver;

namespace CommandMode.Invoker
{
    /// <summary>
    /// 服務生(Invoker)
    /// </summary>
    public class Waitress
    {
        private int dishQty = 2; // 製作熱炒的原料
        private int drinkQty = 4; // 製作飲料的原料
        private List<Order> orders = new List<Order>();

        /// <summary>
        /// 服務生接訂單
        /// </summary>
        /// <param name="order"></param>
        public void SetOrder(Order order)
        {
            string orderName = order.GetName();

            if (orderName.Equals("熱炒訂單"))
            {
                if (dishQty <= 0)
                {
                    Console.WriteLine("熱炒賣完了");
                }
                else
                {
                    Console.WriteLine("增加熱炒訂單");
                    dishQty--;
                    orders.Add(order);
                }
            }
            else if (orderName.Equals("飲料訂單"))
            {
                if (drinkQty <= 0)
                {
                    Console.WriteLine("飲料賣完了");
                }
                else
                {
                    Console.WriteLine("增加飲料訂單");
                    drinkQty--;
                    orders.Add(order);
                }
            }
        }

        /// <summary>
        /// 取消訂單
        /// </summary>
        /// <param name="order"></param>
        public void CancelOrder(Order order)
        {
            string orderName = order.GetName();

            if (orderName.Equals("熱炒訂單"))
            {
                dishQty++;
                Console.WriteLine("取消一份熱炒");
            }
            else if (orderName.Equals("飲料訂單"))
            {
                drinkQty++;
                Console.WriteLine("取消一杯飲料");
            }

            orders.Remove(order);
        }

        /// <summary>
        /// 將訂單送到廚房
        /// </summary>
        public void NotifyKitchen()
        {
            foreach (Order order in orders)
            {
                order.SendOrder();
            }

            orders.Clear();
        }
    }
}
