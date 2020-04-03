using EnumeracoesAula115.Entities;
using EnumeracoesAula115.Entities.Enums;
using System;


namespace EnumeracoesAula115
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
            Console.WriteLine();

            // Convertendo um valor enum para string:

            Console.WriteLine("Convertendo um valor enumerado (enum) para string:");
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);
            Console.WriteLine();

            // Convertendo uma string para o tipo enumerado:

            Console.WriteLine("Convertendo uma string para o tipo enumerado:");
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            Console.WriteLine();

        }
    }
}
