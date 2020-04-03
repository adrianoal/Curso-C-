using System;
using EnumeracoesAula115.Entities.Enums;

namespace EnumeracoesAula115.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                   + ", "
                   + Moment
                   + ", "
                   + Status;

        }



    }
}
