namespace InClass_L3_DelegatesLambdasEvents
{
    internal class Program
    {
        // Created our new delegate
        public delegate double PerformCalculation(double num1, double num2);
        //public delegate int RandomTest();
        static void Main(string[] args)
        {
          



            // Lambdas

            // Events
        } // Main

        // Return type - double
        // Paremeters - double, double

        public static void SuperEfficentLikeCalculator()
        {
            // Can a new delegate be created in a local scope

            PerformCalculation result;

            Console.WriteLine("Calculate");
            Console.WriteLine("1 - Add");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Multiply");
            Console.WriteLine("4 - Divide");
            Console.Write("Enter your choice: ");
            string userChoice = Console.ReadLine();

            Console.Write("Enter number 1 : ");
            double userNumber1 = double.Parse(Console.ReadLine());

            Console.Write("Enter number 2 : ");
            double userNumber2 = double.Parse(Console.ReadLine());

            string userSymbol;
            switch (userChoice)
            {
                case "1":
                    // Add
                    userSymbol = "+";
                    result = Add;
                    break;
                case "2":
                    // Subtract
                    userSymbol = "-";
                    result = Subtract;
                    break;
                case "3":
                    userSymbol = "*";
                    result = Multiply;
                    break;
                case "4":
                    userSymbol = "/";
                    result = Divide;
                    break;
                default:
                    userSymbol = "";
                    result = Add;
                    break;
            }

            double usersCalcuate = result(userNumber1, userNumber2);

            Console.WriteLine($"{userNumber1} {userSymbol} {userNumber2} = {usersCalcuate} ");

            //-----------------------------------------------------------



            /*
             * double result = 0;
             * if(userInput == 1) result = Add(1,2);
             * else if ( userInput == 2) result = Subtract(1,2);
             * else if (userInput == 3 ) result = Multiply(1,2);
             * else if ( userInput == 4 ) result = Divide(1,2);
             * WriteLine(result)
             */




        }

        public static void DelegateExample()
        {
            // Delegates
            //double result = Add(1, 2);

            // keyword delegate
            // 1. Declare a delegate variable, with the assoicated method signature
            // 2. create a new instance of it
            PerformCalculation calculate = new PerformCalculation(Add);


            //PerformCalculation calculate = new PerformCalculation(Multiply);

            //double result = calculate(5, 5);

            //Console.WriteLine("Calculate is Multiply : " + result);

            //calculate = new PerformCalculation(Add);

            //result = calculate(5, 5);

            //Console.WriteLine("Calculate is Add : " + result);





            //Console.WriteLine(result);


        }

        public static double Add(double num1 , double num2)
        {
            return num1 + num2;
        } // Add

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }


        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

    } // class
} // namespace