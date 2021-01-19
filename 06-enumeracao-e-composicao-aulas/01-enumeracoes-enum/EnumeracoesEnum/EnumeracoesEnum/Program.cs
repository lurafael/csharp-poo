using System;
using EnumeracoesEnum.Entities;
using EnumeracoesEnum.Entities.Enums;

namespace EnumeracoesEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Conversões

            //Conversão de tipo enumerado para string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //Conversão de string para tipo enumerado
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);

        }
    }
}
