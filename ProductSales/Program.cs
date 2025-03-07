using ProductSales;

Product electronic = new ElectronicProduct("Laptop", 1000);
Product clothing = new ClothingProduct("T-Shirt", 50);

Console.WriteLine($"{electronic.Name} discounted price: {electronic.GetDiscountedPrice()}$");
Console.WriteLine($"{clothing.Name} discounted price: {clothing.GetDiscountedPrice()}$");