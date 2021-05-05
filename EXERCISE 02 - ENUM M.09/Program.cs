using System;
using EXERCISE_02___ENUM_M._09.Entities;
using EXERCISE_02___ENUM_M._09.Entities.Enums;
namespace EXERCISE_02___ENUM_M._09 {
    //-----> INICIO
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> FIM
}
