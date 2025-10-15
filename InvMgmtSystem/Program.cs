using System;
using System.Collections.Generic;

public class Program
{
    static List<string> productName = new List<string>();
    static List<double> productPrice = new List<double>();
    static List<int> productQuantity = new List<int>();

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Task Manager");
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Update stock");
            Console.WriteLine("3. View products & stocks");
            Console.WriteLine("4. Remove products");
            Console.WriteLine("5. Exit");
            Console.WriteLine("What would you like to do? (choose 1-5)");

            string? input = Console.ReadLine();
            string choice = input ?? string.Empty;

            switch (choice)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    UpdateProduct();
                    break;
                case "3":
                    ViewProduct();
                    break;
                case "4":
                    RemoveProduct();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }

        }
    }

    static void AddProduct()
    {
        Console.WriteLine("Enter product name:");
        string name = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Enter product price:");
        double price;
        double.TryParse(Console.ReadLine(), out price);

        Console.WriteLine("Enter product quantity:");
        int quantity;
        int.TryParse(Console.ReadLine(), out quantity);

        productName.Add(name);
        productPrice.Add(price);
        productQuantity.Add(quantity);

        Console.WriteLine("Product added successfully.");
    }

    static void UpdateProduct()
    {
        Console.WriteLine("Enter product number to update stock:");
        int productNumber;
        int.TryParse(Console.ReadLine(), out productNumber);

        if (productNumber <= 0 || productNumber > productName.Count)
        {
            Console.WriteLine("Invalid product number.");
            return;
        }

        Console.WriteLine("Enter new quantity:");
        int newQuantity;
        int.TryParse(Console.ReadLine(), out newQuantity);

        productQuantity[productNumber - 1] = newQuantity;
        Console.WriteLine($"Product '{productName[productNumber - 1]}' stock updated to {newQuantity}.");
    }

    static void ViewProduct()
    {
        if (productName.Count == 0)
        {
            Console.WriteLine("No products available.");
            return;
        }
        else
        {
            Console.WriteLine("Products:");
            for (int i = 0; i < productName.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {productName[i]} - Price: ${productPrice[i]} - Stock: {productQuantity[i]}");
            }
        }
    }

    static void RemoveProduct()
    {
        Console.WriteLine("Enter product number to remove:");
        int productNumber;
        int.TryParse(Console.ReadLine(), out productNumber);

        if (productNumber <= 0 || productNumber > productName.Count)
        {
            Console.WriteLine("Invalid product number.");
            return;
        }

        string removedProduct = productName[productNumber - 1];
        productName.RemoveAt(productNumber - 1);
        productPrice.RemoveAt(productNumber - 1);
        productQuantity.RemoveAt(productNumber - 1);

        Console.WriteLine($"Product '{removedProduct}' removed successfully.");
    }
}
