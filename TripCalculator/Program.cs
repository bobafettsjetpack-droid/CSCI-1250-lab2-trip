using System.Diagnostics;
using System.Runtime.InteropServices;

/*
* Name: Aaron Robinson
*Course CSCI 1250, Section 001
*Assignment Lab 02, Trip Calculator
*Date September 23, 2026
*Description: Calculates the fuel, food, and work hours behind one road trip.
*/


//Part 1

Console.WriteLine("=== Part 1: Road Trip ===");
Console.Write("Round trip miles: ");
double totalMiles = Convert.ToDouble(Console.ReadLine());

Console.Write("Miles per gallon: ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("Price per gallon: ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = totalMiles / milesPerGallon;

double fuelCost = gallonsNeeded * pricePerGallon;

Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));


//Part 2
System.Console.WriteLine();
Console.WriteLine("=== Part 2: Pizza Party ===");
const int SLICES_PER_PIZZA = 8;

//asking questions
Console.Write("How many people are going: ");
int numberOfPeople = Convert.ToInt32(Console.ReadLine());

Console.Write("How many pizzas: ");
int numberOfPizzas = Convert.ToInt32(Console.ReadLine());

Console.Write("Price per pizza: ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

//calculating
int totalSlices = numberOfPizzas * SLICES_PER_PIZZA;
double slicesPerPerson = (double)totalSlices / numberOfPeople;
double pizzaCost = numberOfPizzas * pricePerPizza;

Console.WriteLine("Total slices: " + totalSlices);
Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
Console.WriteLine("Total pizza cost: " + pizzaCost.ToString("C"));

//Part 3
Console.WriteLine();
Console.WriteLine("=== Part 3: Paycheck ===");
const double TAX_RATE = 0.18;

Console.WriteLine("Hours worked this week: ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Hourly rate: ");
double hourRate = Convert.ToDouble(Console.ReadLine());

//calculating
double grossPay = hoursWorked * hourRate;
double taxWithheld = grossPay * TAX_RATE;
double takeHomePay = grossPay - taxWithheld;

Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));

//Part 4
System.Console.WriteLine();
Console.WriteLine("=== Part 4: The Whole Trip ===");

double tripTotal = fuelCost + pizzaCost;
double costPerPerson = tripTotal / numberOfPeople;
double takeHomePayPerHour = takeHomePay / hoursWorked;
double hoursMustWork = costPerPerson / takeHomePayPerHour;

Console.WriteLine("Trip total: " + tripTotal.ToString("C"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C"));
Console.WriteLine("Hours you must work to cover your share: " + hoursMustWork.ToString("F1"));
