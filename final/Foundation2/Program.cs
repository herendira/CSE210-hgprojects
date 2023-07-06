using System;

class Program
{
    static void Main(string[] args)
    { 
      //Create a client1 with 2 products 
      Client c1= new Client();
      c1.SetCusName("Tom Cruise");
      //Create an Address
      Address a1 = new Address("850N","Valley","USA");
      string direccion = a1.GetFullAdress();
      float numero = a1.EUorNot();
      //Create an order
      Order o1 = new Order(c1);
      //Product 1
      Product p1 = new Product("Decoration Wall",60f,"45678D",3f);
      o1.AddProduct(p1);
      //Product 2
      Product p2 = new Product("Decoration figures",53f,"454588D",10f);
      o1.AddProduct(p2);
      //Display Shipping Labels
      string ficha1 = o1.GetShippingLabel();
      Console.WriteLine(ficha1);
      Console.WriteLine(direccion);
      string ficha = o1.GetPackingLabel();
      Console.WriteLine(ficha);
      //Display total
      float total = o1.TotalOrder();
      total+=numero;
      Console.WriteLine($"Shipping Cost: ${numero}");
      Console.WriteLine($"Total ${total}\n\n");
      

       //Create a client2 with 3 products 
      Client c2= new Client();
      c2.SetCusName("Natalie Portman");
      //Create an Address
      Address a2 = new Address("700N","Sevigny","MEX");
      string direccion2 = a2.GetFullAdress();
      float numero2 = a2.EUorNot();
      //Create an order
      Order o2 = new Order(c2);
      //Product 1
      Product p3 = new Product("White Desk",400f,"45AD34",2f);
      o2.AddProduct(p3);
      //Product 2
      Product p4 = new Product("Bag Safiro",105f,"454577D",3f);
      o2.AddProduct(p4);
      //Product 3
      Product p5 = new Product("Bath and Body Cream",7f,"45777D",3f);
      o2.AddProduct(p5);
      //Display Shipping Labels
      string ficha2 = o2.GetShippingLabel();
      Console.WriteLine(ficha2);
      Console.WriteLine(direccion2);
      string ficha3 = o2.GetPackingLabel();
      Console.WriteLine(ficha3);
      //Display total
      float total1 = o2.TotalOrder();
      total1+=numero2;
      Console.WriteLine($"Shipping Cost: ${numero2}");
      Console.WriteLine($"Total ${total1}\n\n");
       

     //Create a client3 with 4 products 
      Client c3= new Client();
      c3.SetCusName("Brat Pitt");
      //Create an Address
      Address a3 = new Address("1500W","89N","ARG");
      string direccion3 = a3.GetFullAdress();
      float numero3 = a3.EUorNot();
      //Create an order
      Order o3 = new Order(c3);
      //Product 1
      Product p6 = new Product("Couche White",1500f,"70AD34",1f);
      o3.AddProduct(p6);
      //Product 2
      Product p7 = new Product("Moka Table",2005f,"454577D",1f);
      o3.AddProduct(p7);
      //Product 3
      Product p8 = new Product("Moka Chaise",70f,"45007D",7f);
      o3.AddProduct(p8);
      //Product 4
      Product p9 = new Product("Moka coffe table",250f,"45207D",2f);
      o3.AddProduct(p9);
      //Display Shipping Labels
      string ficha4 = o3.GetShippingLabel();
      Console.WriteLine(ficha4);
      Console.WriteLine(direccion3);
      string ficha5 = o3.GetPackingLabel();
      Console.WriteLine(ficha5);
      //Display total
      float total3 = o3.TotalOrder();
      total3+=numero3;
      Console.WriteLine($"Shipping Cost: ${numero3}");
      Console.WriteLine($"Total ${total3}\n");



    }

      

     
}     
      

       

    

