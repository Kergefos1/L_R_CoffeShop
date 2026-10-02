
//Másik Teszt

using ConsoleApp1;

Costumer costumer1 = new Costumer("Alabama", true);
Costumer costumer2 = new Costumer("amabalA", false);
costumer1.AddPoint(6);
costumer2.AddPoint(6);
Console.WriteLine(costumer1.Name);
Console.WriteLine(costumer2.Name);
costumer1.HasDiscount();
costumer2.HasDiscount();

