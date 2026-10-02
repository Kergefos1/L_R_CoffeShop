// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

// Egyik teszt

Drink drink = new Drink("almalé", 1200, false, false);
Drink drink2 = new Drink("almalé", 1200, true, true);

Console.WriteLine(drink.Describe());

Console.WriteLine(drink2.Describe());
﻿
//Másik Teszt


Costumer costumer1 = new Costumer("Alabama", true);
Costumer costumer2 = new Costumer("amabalA", false);
costumer1.AddPoint(6);
costumer2.AddPoint(6);
Console.WriteLine(costumer1.Name);
Console.WriteLine(costumer2.Name);
costumer1.HasDiscount();
costumer2.HasDiscount();

