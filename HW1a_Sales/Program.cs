// HW1a Sales Total

// Your Name:
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double subTotal = 0;
            double salesTax = 0;
            double salesTotal = 0;
            const double taxRate = .085;
            string typeOfItem = "";
            int quantity = 0;
            double priceOfItem = 0;

            Console.WriteLine("Enter the type of item you are purchasing");
            typeOfItem = Console.ReadLine();
            Console.WriteLine("How many " + typeOfItem + "'s do you want to buy?");
            quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the price for " + typeOfItem + "?");
            priceOfItem = double.Parse(Console.ReadLine());

            subTotal = priceOfItem * quantity;
            salesTax = subTotal * taxRate;
            salesTotal = subTotal + salesTax;

            Console.WriteLine("\tYour subtotal for you bill is " + subTotal.ToString("C"));
            Console.WriteLine("\tYour sales tax for you bill is " + salesTax.ToString("C"));
            Console.WriteLine("\tYour total for you bill is " + salesTotal.ToString("C"));
        }
    }
}
