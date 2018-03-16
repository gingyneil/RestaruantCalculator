using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantCalculator
{
    class Program
    {
        static void Main(String[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());
            int tip_percent = Convert.ToInt32(Console.ReadLine());
            int tax_percent = Convert.ToInt32(Console.ReadLine());

            //my code
            double totalTip = CalculateTip(meal_cost, tip_percent);
            double totalTax = CalculateTax(meal_cost, tax_percent);

            double total = meal_cost + totalTax + totalTip;

           total = Math.Round(total);

            System.Console.Write($"the total cost for the meal is {total}");

            System.Console.ReadLine();
        }

        public static double CalculateTip(double meal_cost, int tip_percent)
        {
            double costOfTip = meal_cost * ((double)tip_percent / 100);

            return costOfTip;
        }

        public static double CalculateTax(double meal_cost, int tax_percent)
        {
            double costOfTax = meal_cost * ((double)tax_percent / 100);

            return costOfTax;
        }
    }
}
