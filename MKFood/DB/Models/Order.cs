using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKFood.DB.Models
{
    public class Order
    {

        public int OrderId { get; set; }
     

        public int OrderNumber { get; set; }
        private Food? _food;
        public Food Food
        {
            get => _food ?? throw new InvalidOperationException($"{nameof(Food)} not Inisialize");
            init => _food = value;
        }
        public int Count { get; set; }
        public double Cost { get; set; }
        private Bill? _bill { get; set; }
        public Bill Bill
        {
            get => _bill ?? throw new InvalidOperationException($"{nameof(Bill)} not Inisialize");
            set => _bill = value;
        }

        public override string ToString() => $"food {_food?.Name} add to Order";

    }
}
