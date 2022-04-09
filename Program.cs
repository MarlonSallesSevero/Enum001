using System;
using EnumeracaotEx001.Entities;
using EnumeracaotEx001.Entities.Enums;
namespace Program001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order pedido = new Order
            {
                IntID = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PagamentoPendente
            };
            Console.WriteLine($"{pedido}");
            Console.WriteLine();
            Console.WriteLine("-------- CONVERSAO ENUM PARA STRING");
            string txt = OrderStatus.Enviado.ToString();
            Console.WriteLine(txt);
            Console.WriteLine("-------- CONVERSAO STRING PARA ENUM");
            //OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); try1
            //OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered"); try2 = ok 
            //OrderStatus os; try3 = ok
            //Enum.TryParse("Enviado", out os);
            OrderStatus statusPedido = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Enviado");
            Console.WriteLine(statusPedido);
            string c = Console.ReadLine();
        }
    }
}