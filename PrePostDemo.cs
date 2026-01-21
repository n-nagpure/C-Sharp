namespace Practice
{
    public class  PrePostDemo
    {
        public static void Main()
        {
            int x, y;
            int i;
            x = 1;
            Console.WriteLine("Series generated using Postfix y= x + x++");
            for (i = 0; i < 10; i++)
            {
                y = x + x++;
                Console.WriteLine(y + " ");
            }
            Console.WriteLine();

            x=1;
			Console.WriteLine("Series generated using Prefix y= x + x++");
			for (i = 0; i < 10; i++)
			{
				y = x + ++x;
				Console.WriteLine(y + " ");
			}
			Console.WriteLine();
		}
    }
}
