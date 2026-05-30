using System.ComponentModel.DataAnnotations;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // creating the constructor for the product line item
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // creating a Getter for the order to build labels
    public string GetName()
    {
        return _name;
    }

    // This gets the product information for the order
    public string GetProductId()
    {
        return _productId;
    }

    // Calculating the total price for the order or each product
    public double CalculateTotalProductPrice()
    {
        return _price * _quantity;
    }
}