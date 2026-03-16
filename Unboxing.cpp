class UnBoxing
{
    static public void Main()
    {
        int num = 23;
        object obj = num;
        int i = (int)obj;
        System.Console.WriteLine("Value of Object is {0}",obj);
        System.Console.WriteLine("Value of i is {0}", i);
    }
}
