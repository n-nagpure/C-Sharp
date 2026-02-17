using System;
class Program
{
  static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int temp = num;
        int sum = 0;
        while (num > 0){
            int digit = num % 10;
            int fact = 1;
            for (int i = 1; i <= digit; i++){
                fact = fact * i;
            }
            sum = sum + fact;
            num = num / 10;
        }
        if (sum == temp)
            Console.WriteLine("The number is a Krishnamurthy  Number");
        else
            Console.WriteLine("The number is not a Krishnamurthy  Number");
              Console.ReadLine();
    }
}
