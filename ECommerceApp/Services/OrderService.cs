namespace ECommerceApp.Services
{
    public class OrderService
    {
        public Order LastPlacedOrder { get; private set; }
        private Order currentOrder;
        public void InitializeOrder(Product product)
        {
            currentOrder = new Order
            {
                Customer = new Customer(), 
                Items = new List<CartItem>
                {
                    new CartItem { Product = product, Quantity = 1 } 
                },
                TotalPrice = product.Price 
            };
        }
        public void AddQuantityToProduct(Product product, int quantityChange)
        {
            var cartItem = currentOrder.Items.FirstOrDefault(item => item.Product.Id == product.Id);
            if (cartItem != null)
            {
                cartItem.Quantity += quantityChange;
                if (cartItem.Quantity < 1) cartItem.Quantity = 1;
            }
            else
            {
                currentOrder.Items.Add(new CartItem { Product = product, Quantity = 1 });
            }
            currentOrder.TotalPrice = GetTotalPrice();
        }

        public void PlaceOrder(Customer customer)
        {
            if (currentOrder == null) return;
            currentOrder.Customer = customer;
            currentOrder.TotalPrice = GetTotalPrice(); 
            LastPlacedOrder = currentOrder;
        }
        
        public List<CartItem> GetOrderItems() => currentOrder?.Items ?? new List<CartItem>();
        public decimal GetTotalPrice() => currentOrder?.Items.Sum(item => item.Product.Price * item.Quantity) ?? 0m;
        private List<Order> Orders { get; set; } = new();
    }
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Total => Product.Price * Quantity;
    }
    public class Order
    {
        public Customer Customer { get; set; }
        public List<CartItem> Items { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
