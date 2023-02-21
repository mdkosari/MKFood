using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MKFood.DB.Models
{
    public class Food
    {
        public Food(string name, string description, string picture, int foodId = default) => (Name, Description,Picture, FoodId) = (name, description, picture, foodId);

        public int FoodId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Picture { get; set; }
        public DateTime Created { get; set; }

        private Category? _category;
        public Category Category {
            get => _category ?? throw new InvalidOperationException($"{nameof(Category)} not inisialize");
            init => _category = value;
        }

        public ICollection<Price> Prices { get; } = new List<Price>();
        

        public override string ToString() => Name;
    }
}
