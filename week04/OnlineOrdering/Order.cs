using System;
using System.Collections.Generic;

class Order
{
    // Fields
    private List<Product> _products;
    private Customer _customer;
    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();

    }
    //Methods
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetTotalPrice()
    {
        double totalCost = 0.0;
        double shippingCost;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        if (_customer.IsCustomerInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        totalCost += shippingCost;
        return totalCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"Product(s): {product.GetName()} \nI.D: {product.GetProductId()}\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        string shippingLabel = $"Name: {_customer.GetCustomerName()} \nAddress: {_customer.GetFullAddress()}";
        return shippingLabel;
    }
}


