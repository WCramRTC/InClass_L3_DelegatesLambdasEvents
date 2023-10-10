namespace InClass_L3_DelegatesLambdasEvents
{
    internal class Program
    {
        // Created our new delegate
        public delegate double PerformCalculation(double num1, double num2);
        //public delegate int RandomTest();
        static void Main(string[] args)
        {

           


            // Events
        } // Main

        #region Lambdas

        public static void LambdasExample()
        {

            // Lambdas - Anonymous Method
            // The lambda symbol =>
            // Delegate name = (parmeters) => code
            Func<double, double, double> add = (x, y) => x + y;

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 56 };
            // double SumOfNumbers(List<int>)
            /*
             * double sum = 0;
             *             * foreach (int num in list) sum += num;
             * return sum;
             */

            Func<List<int>, double> sumOfNumbers = list =>
            {
                double sum = 0;
                foreach (var number in list)
                {
                    if (number == number)
                    {
                        sum += number;
                    }

                }
                return sum;
            };
        }

        #endregion

        #region Ednalynns Chaining Code

        public static void ChainingCode()
        {
            Func<List<int>, double> sumOfNumbersLinq = list => list.Sum();

            // Action - No return type, paramters
            Action<string> customMessage = x =>
            {
                Console.WriteLine($"Welcome to {x} class!");

            };


            customMessage("Programming 226");

            // Built in methods and passing in delegates to get results by chaining returns

            // Ednalynn code
            Func<List<int>, double> sumOfEvenNumbers = list => list.Where(x => x % 2 == 0).Sum();

            // Of numbers
            // Call the where method on it, and pass in our condition, x % 2 == 0 true
            // ListOfEven


            Console.WriteLine("Ednalynn is a head of the game : " + sumOfEvenNumbers(numbers));



            //Console.WriteLine(sumOfNumbers(numbers));



            // double Add(double x, double y) { return x + y };

        }

        #endregion

        #region Generic Delegates

        // Generic Delegates

        public static double SomeNumber()
        {
            return 5;
        }

        public static void GenericExample()
        {
            // Generic Delegates

            // Predicate - Always returns a bool, and takes a single type
            // bool DelegateName(string);
            Predicate<string> startsWithA = StartsWithA;

            // Action - Has a void return type, can take upto 15 combinations of parameters
            Action<string, string, double> randomMethod = RandomMethod;

            // Func - You can assign return type and params in declaration
            // The last type placed in the carrots will always be the return type
            Func<double, double, double> calculate = Add;
            Func<int, string, bool, double, bool, int, string, bool> whatever;
        }

        public static void RandomMethod(string a, string b, double c)
        {

        }

        public static bool StartsWithA(string word)
        {
            return word[0] == 'A';
        }

        // Return type - double
        // Paremeters - double, double
        #endregion

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

        #region Delegate

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

        #endregion

    } // class
} // namespace