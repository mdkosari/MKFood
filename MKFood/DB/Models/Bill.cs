namespace MKFood.DB.Models
{
    public class Bill
    {
        public Bill(bool success)
        {
            Success = success;

        }
        public int BillId { get; set; }
        private Customer? _customer;
        public Customer Customer
        {
            get => _customer ?? throw new InvalidOperationException($"{nameof(Customer)} cannot be null.");
            init => _customer = value;
        }

        public ICollection<Order> orders { get; } = new List<Order>();

        public double Fee { get; set; }
        public double Tax { get; set; }

        public Double SumCost { get; set; }

        public bool Success { get; set; }

        public DateTime Created { get; set; }

        public override string ToString() => _customer?.Name ?? "Bill Not Found";

    }
}
