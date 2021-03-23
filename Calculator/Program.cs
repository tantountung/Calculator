using System;

namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello Sir/Madam!!");
            bool keepLooping = true;

            do
            {
                MainMenu();
                Console.WriteLine("Do you want to do calculation again?\nCLick Y if Yes or other key to end the program");
                string userAnswer = Console.ReadLine();
                if (userAnswer.ToUpper() != "Y")//if true, no need to put inside 'if', Y always in "" because it is string
                {
                    keepLooping = false;//dont use 'wrong'
                }

            } while (keepLooping);
            //Ctrl KD, make it neat

        }

        public static void MainMenu()//menu same level with Main and uppercase, except variable

        {
            Console.WriteLine("  ");//cw double tap
            Console.WriteLine("  ");
            Console.WriteLine("1.Addition\n2.Substraction\n3.Multiplication\n4.Division");
            Console.WriteLine("  ");
            Console.Write("Please enter your choice:");

            int userChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            switch (userChoice)
            {
                case 1:
                    result = Addition(firstNumber, secondNumber);
                    break;
                case 2:
                    result = Substraction(firstNumber, secondNumber);
                    break;
                case 3:
                    result = Multiplication(firstNumber, secondNumber);
                    break;
                case 4:
                    result = Division(firstNumber, secondNumber);
                    break;
                default:
                    Console.WriteLine("Invalid choice, please choice from the main menu");
                    MainMenu();
                    break;
            }

            Console.WriteLine("The result is:  {0}", result);
           

        }

        public static double Addition(double firstNumber, double secondNumber)

        {
            return firstNumber + secondNumber;
        }

        public static double Substraction(double firstNumber, double secondNumber)


        {

            return firstNumber - secondNumber;



        }

        public static double Multiplication(double firstNumber, double secondNumber)


        {
            return firstNumber * secondNumber;



        }

        public static double Division(double firstNumber, double secondNumber)


        {

            if (secondNumber == 0)
            {
                Console.WriteLine("You cannot divide with 0, please repeat entering correct divider number.");

                return secondNumber;

            }
            else
            {
                return firstNumber / secondNumber;





            }
            //Console.ReadKey();//only at the end because no use in every method

        }
        public static double OverloadArray_Additional(double[] numbers)
        {
            double sum = 0;

            foreach (double num in numbers)
            {
                sum = num + sum;
            }
            return sum;

        }
        public static double OverloadArray_Substraction(double[] numbers)
        {
            double sum = 0;

            foreach (double num in numbers)
            {
                sum = sum - num;
            }
            return sum;

        }
    }
}
