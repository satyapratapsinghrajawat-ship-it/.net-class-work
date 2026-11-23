using System;

class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; }

    public double DiscountPrice
    {
        get
        {
            if (Price >= 10000)
                return Price - (Price * 0.20);
            else if (Price >= 5000)
                return Price - (Price * 0.10);
            else
                return Price;
        }
    }
}

class Program
{
    static void Main()
    {
        Product p = new Product();

        p.ProductName = "Laptop";
        p.Price = 15000;

        Console.WriteLine("Product Name: " + p.ProductName);
        Console.WriteLine("Original Price: " + p.Price);
        Console.WriteLine("Final Price: " + p.DiscountPrice);
    }
}