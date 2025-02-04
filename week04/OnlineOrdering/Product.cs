using System;

class Product
{
    //Fields
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;
    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    // Methods
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetProductId()
    {
        return _productId;
    }
}




