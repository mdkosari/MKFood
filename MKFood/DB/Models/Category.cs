using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKFood.DB.Models
{
    public class Category
    {
        public Category(string name,int categoryId = default) => (Name,CategoryId) = (name,categoryId);
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public ICollection<Food> Foods { get; } = new List<Food>();

        public override string ToString() => Name;
    }
}
