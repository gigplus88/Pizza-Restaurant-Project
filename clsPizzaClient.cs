using Pizz_aBusiness_Layer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    internal class clsPizzaClient
    {
        public string FullName { get; set; }

        private static  Queue<clsPizzaOrder> _orderQueue = new Queue<clsPizzaOrder>();
        private static object _lock = new object();

        public clsPizzaClient(string FullName, Queue<clsPizzaOrder> orderQueue)
        {
            this.FullName = FullName;
            _orderQueue = orderQueue;
        }

        public static void SendOrder(clsPizzaOrder order)
        {
            lock (_lock)
            {
                _orderQueue.Enqueue(order);
            }
            
        }
        public static clsPizzaOrder ReceiveOrder()
        {
            lock (_lock)
            {
                if (_orderQueue.Count > 0)
                    return _orderQueue.Dequeue(); 
                else
                    return null;  
            }
        }
        public static int OrdersCount
        {
            get
            {
                lock (_lock)
                {
                    return _orderQueue.Count;
                }
            }
        }


        public  void SimulateOrders()
        {
            var random = new Random();

            string[] sizes = { "Small", "Medium", "Large" };
            string[] crusts = { "Thin", "Thick" };
            string[] toppings = { "Cheese", "Olives", "Peppers", "Tomatoes", "Mushrooms" };

            for (int i = 0; i < 3; i++)
            {
                //var order = new clsPizzaOrder
                //{
                //    //Size = sizes[random.Next(sizes.Length)],
                //    //Crust = crusts[random.Next(crusts.Length)],
                //    //Price = random.Next(30, 90)
                //};

                //order.Toppings.Add(toppings[random.Next(toppings.Length)]);

                //SendOrder(order);

                Thread.Sleep(1000);
            }
        }
    }
}
