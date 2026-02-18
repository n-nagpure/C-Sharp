###Call By Value
using System;
class Program {
    static void ChangeValue(int x)
    {
        x = 200;
        Console.WriteLine(x);
    }

    static void Main(string[] args) {
        int i = 100;
        Console.WriteLine(i);
        ChangeValue(i);
        Console.WriteLine(i);

    }
}

###Call By Reference
using System;
class Program {
    String StudentName;
    static void ChangeReferenceType(Program std2)
    {
        std2.StudentName = "Steve";
    }

    static void Main(string[] args) {
        Program std1=new Program();
        std1.StudentName = "Bill";
        Console.WriteLine(std1.StudentName);
        ChangeReferenceType(std1);
        Console.WriteLine(std1.StudentName);

    }
}

