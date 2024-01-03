﻿using Parprogrammering6;

class Program
{
    static void Main()
    {
        ClothingItem shirt = new ClothingItem("Men`s T-shirt", 50, 200, "Large", "Blue");
        var salePrice = shirt.CalculatePrice();
        Console.WriteLine($"The sale price of the shirt is: {salePrice}");
        ElectronicItem phone = new ElectronicItem("Iphone X", 25, 3400, "1 year", 24);
        salePrice = phone.CalculatePrice();
        Console.WriteLine($"The sale price of the phone is: {salePrice}");
    }
}
