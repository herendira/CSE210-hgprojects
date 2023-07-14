using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Product
{
    
    private string _productname;
    private float _productprice;
    private string _idproduct;
    private float _quantity;

    //Constructors

    public Product(string productname, float productprice, string idproduct, float quantity)
    {
        _productname = productname;
        _productprice = productprice;
        _idproduct = idproduct;
        _quantity = quantity;

    }
    public Product()
    {
        _productname = "" ;
        _productprice = 0;
        _idproduct = "";
        _quantity = 0;
    }
    
    //getters

    public string GetProductName()
    {
        return _productname;
    }

    public float GetProductPrice()
    {
        return _productprice;
    }
    
    public float GetQuantity()
    {
        return _quantity;
    }

    public string GetIdProduct()
    {
        return _idproduct;
    }

    
}    
    