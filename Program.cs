namespace InClass_L3_DelegatesLambdasEvents
{
    internal class Program
    {
        // Created our new delegate
        public delegate double PerformCalculation(double num1, double num2);
        //public delegate int RandomTest();
        static void Main(string[] args)
        {
            // Can a new delegate be created in a local scope



            //-----------------------------------------------------------



            /*
             * double result = 0;
             * if(userInput == 1) result = Add(1,2);
             * else if ( userInput == 2) result = Subtract(1,2);
             * else if (userInput == 3 ) result = Multiply(1,2);
             * else if ( userInput == 4 ) result = Divide(1,2);
             * WriteLine(result)
             */







            // Lambdas

            // Events
        } // Main

        // Return type - double
        // Paremeters - double, double

        public static void DelegateExample()
        {
            // Delegates
            //double result = Add(1, 2);

            // keyword delegate
            // 1. Declare a delegate variable, with the assoicated method signature
            // 2. create a new instance of it
            PerformCalculation calculate = new PerformCalculation(Add);
            // calculate = Add
            // calculate(45,60) = Add(45,60)
            //double result = Add(1, 2);
            double result = calculate(1, 2);


            //PerformCalculation calculate = new PerformCalculation(Multiply);

            //double result = calculate(5, 5);

            //Console.WriteLine("Calculate is Multiply : " + result);

            //calculate = new PerformCalculation(Add);

            //result = calculate(5, 5);

            //Console.WriteLine("Calculate is Add : " + result);



            Console.WriteLine("The result of my calculate delegate is " + result);


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