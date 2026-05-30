public class Order
{
    // private list form orders with multiple products
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // basic contructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    //  this allows the products to move to the order list
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    //  calculates the master total for the order 
    public double CalculateTotalCost()
    {
        double subtotal = 0;

        // create a loop for each product in the order 
        foreach (Product product in _products)
        {
            subtotal += product.CalculateTotalProductPrice();
        }

        // adding a shipping fee for where the customer is located
        double shippingFee = _customer.IsInUSA() ? 5.00 : 35.00;
        return subtotal + shippingFee;
    }

    // creating a string for customer and address for packing 
    public string GetPackingLabel()
    {
        string label = "----- Packing Label ----\n";
        foreach (Product product in _products)
        {
            // builds out each product info
            label += $"Item: {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    // this is where the shipping label will be built
    public string GetShippingLabel()
    {
        string label = "----- Shipping Label ---\n";
        // customer objet feeds name and address string
        label += $"{_customer.GetCustomerName()}\n";
        label += _customer.GetFullAddress() + "\n";
        return label;
    }
}