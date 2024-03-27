//Lab 10: Using Recursion
//Evan Nguyen
//Due date: 31/03/2024
namespace Lab10_Recursion
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Addition");
            Console.WriteLine("Enter number n: ");
            int inputN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number m: ");
            int inputM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{SumCalculate(inputN, inputM)}");

            Console.WriteLine("Division");
            Console.WriteLine("Enter your number: ");
            int numberInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total number of divisions: {NumberDivideEvenly(numberInput)}");
        }
        //Method for Additioning the number using recursion
        public static int SumCalculate(int n, int m)
        {
            if(n > m)
            {
                return 0;
            }
            while(n <= m)
            {
                int sum = n + SumCalculate(n + 1, m);
                return sum;
            }
            return n + m;
        }

        //Method for counting the number the user entered can be divided evenly by 2
        public static int NumberDivideEvenly(int number)
        {
            if (number % 2 == 0 && number > 0)
            {
                int count;
                count = 1 + NumberDivideEvenly(number / 2);
                return count;
            }
            else
            {
                return 0;
            }
        }
    }
}
