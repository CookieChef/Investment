using System;

namespace Investment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greets user and prompts user input, takes the value and parse them into floats
            Console.WriteLine("Hello!");
            Console.WriteLine("Every year you will get an 8% annual return added to your balance");
            Console.WriteLine("Please enter your investment amount");
            var investmentAmount = float.Parse(Console.ReadLine());
            Console.WriteLine("Now please enter the number or years for this investment");
            var numberYears = Int32.Parse(Console.ReadLine());

            //conditionals to print total balance and make sure user inputs correct amount of years
            if(numberYears >1 && numberYears <= 30) {
                var totalbalance = (investmentAmount * numberYears) + (investmentAmount * numberYears * .08);
                Console.WriteLine("Your total balance at the end of your selected time period will be: $" + totalbalance);
                Console.WriteLine("Your total amount for each year will be listed below: ");

                //Loop that prints each year's balance 
                while (numberYears > 0) {
                    var balance = (investmentAmount * numberYears) + (investmentAmount * numberYears * .08);
                    Console.WriteLine("Balance on year #" + numberYears + " is: $"+ balance);
                    numberYears --;
                }
            //conditional that prevent user from calculating for more than 30 years
            }else if (numberYears > 30) {
                Console.WriteLine("We are sorry, but we can only calculate based on a 30 year investment");
                Console.WriteLine("Please select a different amount of years to calculate");
            } else {
                Console.WriteLine("Im sorry, what?");
            }
        }
    }
}
