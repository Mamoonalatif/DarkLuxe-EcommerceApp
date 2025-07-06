namespace ECommerceApp.Services
{
    public class CustomerService
    {
        private readonly List<Customer> customers = new();
        private readonly Random random = new();

        public int GenerateUniqueId()
        {
            int id;
            do
            {
                id = random.Next(1000, 9999);
            } while (customers.Any(c => c.Id == id));
            return id;
        }

        public void SaveCustomer(Customer customer)
        {
            customer.Id = GenerateUniqueId();
            customers.Add(customer);
        }
    }
    public class Customer
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
    }
}
