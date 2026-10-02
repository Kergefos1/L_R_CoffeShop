// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

// Egyik teszt

Drink drink = new Drink("almalé", 1200, false, false);
Drink drink2 = new Drink("almalé", 1200, true, true);

Console.WriteLine(drink.Describe());

Console.WriteLine(drink2.Describe());