// See https://aka.ms/new-console-template for more information
using csharpquarium;

Carnivore carnitest = new Carnivore();
Herbivore herbitest = new Herbivore();
Plant plantitest = new Plant();

carnitest.Display();
herbitest.Display();
plantitest.Display();

Console.WriteLine(plantitest.GetType());
Console.WriteLine(carnitest.GetType().ToString());

Console.ReadKey();
