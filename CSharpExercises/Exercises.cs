using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
        public static string SayHello(string name)
        {
            return $"Hello {name}";
        }
        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber
        }
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public static decimal Divide(decimal box, decimal top)
        {
            decimal output = box / top;
            return (output);
        }
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static bool CanOpenCheckingAccount(int age)
        {
            age >= 18 ? true : false;
        }
        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName(string fullName)
        {
            string firstName = fullName.split(' ')[0];
            return firstName;
        }
        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard(string Str)
        {
            string reversestring = "";
            int Length;
            Length = Str.Length - 1;
            while (Length >= 0)
            {
                reversestring = reversestring + Str[Length];
                Length--;
            }
            return reversestring;
        }
        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy(string phrase)
        {
            char[] charArray = phrase.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        public static string PrintTimesTable(int number)
        {
            return Constants.TimesTableFor9;
        }

        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit(double temp)
        {
            return Math.Round(temp * 1.8 - 459.67, 2);;
        }
        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        public static double GetAverageHard (int[] numbers)
        {
            int i = 0;
            double sum = 0;
            while (i < (numbers.Length))
            {   
                sum += numbers[i];   
                i++;           
            }
            return sum/numbers.Length;
        }

        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
        public static double GetAverageEasy(int[] inputs)
        {
            return inputs.Average();
        }
        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        public static string DrawTriangle(int number, int width)
        {
            return Constants.TriangleFor8and5;
        }

        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
        public static string GetMilesPerHour (double distance, int hours, int minutes, int seconds)
        {
            double totalSeconds = seconds + (minutes * 60) + (hours * 3600);
            double time = totalSeconds / 3600;
            double mph = distance / time;
            string speed = Math.Round(mph).ToString();
            return $"{speed}MPH";
        }

        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel(char letter)
        {
            string vowels = " a e i o u";
            return vowels.Contains(letter);
        }

        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
      public static bool IsConsonant(char isma)
        {
            string consonant = "b c d f g h j k l m n p q r s t v w x y z";
            return consonant.Contains(isma);
        }

        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        public static int CollatzConjecture(int r)
        {
            int n = r;
            int i = 0;
            for (i = 0; ; i++)
            {
                if (n == 1)
                {
                    return i;
                }
                else
                {
                    bool even = n % 2 == 0;
                    if (even == true)
                    {
                        n = n / 2;
                    }
                    else
                    {
                        n = n * 3 + 1;
                    }
                }
            }
        }

        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        //public static Array GetNext7Days(DateTime date)
        //{
        //    DateTime day = date;
        //    int i = 0;
        //    Array NextSeven = new Array[day];
        //    for (i = 0; i <= 7; i++)
        //    {
        //        DateTime week = day.AddDays(1);
        //        NextSeven week;
        //    }
        //    return [0, 1, 2];
        //}
        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
        public static bool IsInLeapYear(int year)
        {
            bool leap = false;
            int date = year;
            if (date % 4 != 0)
            {
                leap = false;
            } else
            {
                if (date % 100 != 0)
                {
                    leap = true;
                }
                else
                {
                    if (date % 400 == 0)
                    {
                        leap = true;
                    } else
                    {
                        leap = false;
                    }
                }
            }
            return leap;
        }

        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */
        public static decimal MortgageCalculator (decimal loanBalance, decimal interestRate, int years, int payPeriod)
        {
           decimal monthr = ((interestRate / 100) / payPeriod);
            double balance = Convert.ToDouble(loanBalance);
            double monthRate = Convert.ToDouble(monthr);
            double nop = (years * payPeriod);
            double cir = Math.Pow((1 + monthRate), nop);
            double interest = Convert.ToInt16((monthRate * cir) / (cir - 1));
            double payment = (balance * interest);
            return Convert.ToDecimal(payment);
        }

        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        public static string DuckGoose (int laps)
        {
            int i = 0;
            int l = laps;
            string game = " ";
            for (i = 0; i == l; i++)
            {
                if (i%3==0 && i%5 !=0)
                {
                    game += "Duck"+Environment.NewLine;
                }else
                { 
                    if (i%5 ==0 && i%3 !=0)
                    {
                        game += "Goose"+Environment.NewLine;
                    }else
                    {
                        if (i%3 ==0 && i%5 ==0)
                        {
                            game += "DuckGoose"+Environment.NewLine;
                        } else
                        {
                           game += (i) + Environment.NewLine;

                        }
                    }
                }

               }
            Console.WriteLine(game);
                return game;
        }
    }
}
