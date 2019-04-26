using System;

namespace Mortgage_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            /* If you take out a loan from a bank of $10,000 with an annual interest rate of %5 percent, 
             * how much is your monthly payments over a term of 36 months going to be? What if you pay $50 dollars more a month,
             * how long will it take you then to pay it back then?
             * Create a program which asks the user for a loan amount (principal),
             * the interest rate and the term. Make it generate a payment schedule showing how much the user has to pay per month over 
             * the course of the term to pay it all back. At the end, print the how much the user will really pay over the course of 
             * the loan.
             */
            Console.WriteLine("Hello user, please enter how much money you need: ");
            double loan = double.Parse(Console.ReadLine());

            Console.WriteLine("Loan Term (months):");
            int term = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the interest rate %:");
            double IR = double.Parse(Console.ReadLine());
            //dividig it to 12months then to 100% and we have the coefficient and rounding the number
            double interestRate = Math.Round(((IR / 12)/100.0),4);

            //main formulla
            double monthly = loan / ((1 / interestRate) * (1 - (1 / Math.Pow((1 + interestRate), term))));  

            Console.WriteLine("\n\nYou have to pay ${0} per month for {1} months.", Math.Round(monthly,2), term);
           
            int monthly50more = (int)(monthly * term) / (int)(monthly + 50);
            Console.WriteLine("\nIf you pay 50 more per month, you'll pay it all back for {0} months.", monthly50more);

            Console.WriteLine("\nWith {0}% interest rate, you will really pay ${1}.", IR, Math.Round((monthly * term),2));


            Console.ReadLine();
        }
    }
}
