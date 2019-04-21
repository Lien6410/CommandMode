using NUnit.Framework;
using CommandMode.Invoker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandMode.Receiver;
using CommandMode.Command;

namespace CommandMode.Invoker.Tests
{
    [TestFixture()]
    public class WaitressTests
    {
        [Test()]
        public void CommandModeTest()
        {
            Console.WriteLine("======== 命令模式測試 =========");

            //開店準備
            Chef chef = new Chef();
            Bartender bartender = new Bartender();
            Order dishOrder = new DishOrder(chef);
            Order drinkOrder = new DrinkOrder(bartender);
            Waitress cuteGirl = new Waitress();

            //開始營業 客戶點餐
            cuteGirl.SetOrder(dishOrder);
            cuteGirl.SetOrder(dishOrder);
            cuteGirl.SetOrder(drinkOrder);
            cuteGirl.SetOrder(drinkOrder);

            //飲料還沒賣完
            cuteGirl.SetOrder(drinkOrder);

            Console.WriteLine("===== 客人取消熱炒測試 =====");
            //取消一份熱炒
            cuteGirl.CancelOrder(dishOrder);
            //熱炒又可以賣了
            cuteGirl.SetOrder(dishOrder);

            Console.WriteLine("=== 點餐完成 通知廚房 ===");
            cuteGirl.NotifyKitchen();

            Console.WriteLine("=== 熱炒庫存不足測試 ===");
            cuteGirl.SetOrder(dishOrder);

            Assert.AreEqual(1,1);
        }
    }
}