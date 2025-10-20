using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    internal class clsPizzaClient
    {
        public string Name { get; set; }
        public int Age { get; set; }

        private readonly Queue<clsPizzaOrder> _orderQueue;
        private readonly object _lock = new object();

        public clsPizzaClient(string name, int age, Queue<clsPizzaOrder> orderQueue)
        {
            Name = name;
            Age = age;
            _orderQueue = orderQueue;
        }

        // إرسال الطلب إلى الطابور
        public void SendOrder(clsPizzaOrder order)
        {
            lock (_lock)
            {
                _orderQueue.Enqueue(order);
            }
        }

        // محاكاة زبائن يطلبون بيتزا
        public void SimulateOrders()
        {
            var random = new Random();

            string[] sizes = { "Small", "Medium", "Large" };
            string[] crusts = { "Thin", "Thick" };
            string[] toppings = { "Cheese", "Olives", "Peppers", "Tomatoes", "Mushrooms" };

            for (int i = 0; i < 3; i++)
            {
                var order = new clsPizzaOrder
                {
                    //Size = sizes[random.Next(sizes.Length)],
                    //Crust = crusts[random.Next(crusts.Length)],
                    //Price = random.Next(30, 90)
                };

                order.Toppings.Add(toppings[random.Next(toppings.Length)]);

                SendOrder(order);

                Thread.Sleep(1000);
            }
        }
    }
}
