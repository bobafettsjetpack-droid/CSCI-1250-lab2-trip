using System.Diagnostics;
/*formatting
gallonsNeeded.ToString("F2");
slicesPerPerson.ToString("F1");
fuelCost.ToString("C");
*/



Console.Write("How many miles is the round trip? ");
double totalMiles = Convert.ToDouble(Console.ReadLine());

Console.Write("How many miles per gallon do you get? ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("What is the price per gallon of gas? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = totalMiles / milesPerGallon;

double fuelCost = gallonsNeeded * pricePerGallon;

Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));


//Part 2

const int SLICES_PER_PIZZA = 8;

//asking questions
Console.Write("How many people are going on the trip? ");
int numberOfPeople = Convert.ToInt32(Console.ReadLine());

Console.Write("How many pizzas are there? ");
int numberOfPizzas = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the price per pizza? ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

//calculating
int totalSlices = numberOfPizzas * SLICES_PER_PIZZA;
double slicesPerPerson = (double)totalSlices / numberOfPeople;
double pizzaCost = numberOfPizzas * pricePerPizza;

Console.WriteLine("Total slices: " + totalSlices);
Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
Console.WriteLine("Total pizza cost: " + pizzaCost.ToString("C"));

