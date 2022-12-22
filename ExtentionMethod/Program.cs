using System;

namespace ExtentionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test extention method to add new functionaltiy to private edit type as DateTime
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.IsWeekend());

            //test chain method by extention method
            Order order = new Order();
            order.OrderItem1().OrderItem3().OrderItem2().OrderItem4();
            Console.WriteLine(order.ToString());
            Console.ReadLine();
        }
    }
}
