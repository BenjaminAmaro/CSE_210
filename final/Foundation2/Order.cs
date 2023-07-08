using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer _customer;
    
    public Order(Customer customer)
    {
        _customer = customer;
        products = new List<Product>();
    }
        
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in products)
        {
            label += $"Name: {product.GetProductName()}, Product ID: {product.GetProductId()}\n";
        }
        return label;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    
    public string GetShippingLabel()
    {
        return $"Shipping Label:\nName: {_customer.GetCostumerName()}\nAddress: {_customer.GetCostumerAddress().GetFullAddress()}";
    }
    public double GetFinalPrice()
    {
        double total = 0;
        foreach (Product product in products)
        {
            total += product.GetPrice();
        }
        
        if (_customer.Location())
        {
            total += 5.0;
        }
        else
        {
            total += 35.0;
        }
        return total;
    }

}
