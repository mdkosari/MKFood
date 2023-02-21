
namespace MKFood.DB.Models
{
    public class Customer
    {
        public Customer(string name) => (Name) = (name);
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int AccountNumber { get; set; }

        public override string ToString() => Name;
    }
}
