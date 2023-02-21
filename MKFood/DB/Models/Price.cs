using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKFood.DB.Models
{
    public class Price
    {
        public Price(double cost, int priceId = default) => (Cost, PriceId) = (cost, priceId);
        public int PriceId { get; set; }
        public double Cost { get; init; }
        public bool Expierd { get; set; } = false;
        public DateTime Created { get; set; }


        private Food? _food;
        public Food Food
        {
            get => _food ?? throw new InvalidOperationException($"{nameof(Food)} not inisialize");
            init => _food = value;
        }

        public override string ToString() => $"Price = {_food}";
    }
}
