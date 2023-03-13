namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Print1000s()
           
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
         
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintThrees()
        {
            for(var i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }


        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void EqualNumbers(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("The numbers are equal");
            }
            else
            {
                Console.WriteLine("The numbers are not equal");
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is odd");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static void PosOrNeg(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive");
            }
            else
            {
                Console.WriteLine($"{number} is negative");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void VotingAge()
        {
            bool userAge;
            int result;

            do
            {
                Console.WriteLine("Please enter your age:");
                userAge = int.TryParse(Console.ReadLine(), out result);
            
            } while (!userAge);

            if (result < 18)
            {
                Console.WriteLine("Come back when you're 18.");
            }
            else
            {
                Console.WriteLine("Have fun voting!");
            }
        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void Within10()
        {
            bool userNumber;
            int result;
            do
            {
                Console.WriteLine("Please enter a number.");
                userNumber = int.TryParse(Console.ReadLine(),out result);

            } while (!userNumber);
            if(result >= -10 && result <= 10)
            {
                Console.WriteLine("Your number is within -10 and 10.");
            }
            else
            {
                Console.WriteLine("Your number isn't within -10 and 10.");
            }
            
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable()
        {
            bool userNumber;
            int result;
            do
            {
                Console.WriteLine("Please enter a number.");
                userNumber = int.TryParse(Console.ReadLine(), out result);

            } while (!userNumber);

            for(var x = 1; x <= 12; x++)
            {
                Console.WriteLine($"{x} x {result} = {x * result}");
            }
            
        }


        //Call the methods to test them in the Main method below


        static void Main(string[] args)
        {
            //Print1000s();

            //PrintThrees();

            //EqualNumbers(6, 9);

            //EqualNumbers(7, 7);

            //EvenOrOdd(8);
            //EvenOrOdd(7);

            //PosOrNeg(5);
            //PosOrNeg(-5);

            //VotingAge();

            //Within10();

            MultiplicationTable();

       







        }
    }
}
