namespace First_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isPrime = true;

            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number <= 1)
            {
                isPrime=false;
            }
            for (int j = 2; j < number/2; j++)
            {
                if (number % j == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime){
                Console.WriteLine(number +" is a prime number");
            }
            else
            {
                Console.WriteLine(number +" is not Prime Number");
            }
        }
    }
}
