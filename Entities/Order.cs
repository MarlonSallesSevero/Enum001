using System;
using EnumeracaotEx001.Entities;
using EnumeracaotEx001.Entities.Enums;

namespace EnumeracaotEx001.Entities
{
    internal class Order
    {
        public int IntID { get; set; }
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }
        public override string ToString()
        {
            return $"{IntID} , {Moment}, {Status}";
        }
    }
}