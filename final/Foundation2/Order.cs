using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Order
{
    //Constructors
    private List<Product> _products;
    private Client _client;
    private Address _address;
    private float _shippingcost; 
   
   
    //constructors
    public Order(Client client)
    {
        _products = new List<Product>();
        _client = client;
        _shippingcost = 0;
       
    }
    public Order()
    {

    }

    public Order(Address address)
    {
        _shippingcost= address.EUorNot();
        _address = address;
    }

    //Methods
    public void AddProduct(Product product)
    {
          _products.Add(product);
    }

     public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();  // concatenation of strings
        foreach (Product product in _products)
        {   
            label.AppendLine($"ID Product: {product.GetIdProduct()}\nProduct Name:{product.GetProductName()}\nPrice: ${product.GetProductPrice()}\nQuantity: {product.GetQuantity()}");
        }
         
         return label.ToString();// convertion to string representation.
    }

    public string GetShippingLabel()
    {
        return $"Client: {_client.GetCustName()}\n";
    }
    
    public float TotalOrder()
    {
    float totalPrice = 0;
    foreach (Product product in _products)
    {
        float productTotal = product.GetProductPrice() * product.GetQuantity();
        totalPrice += productTotal;
    }
    return totalPrice;
    }

}


