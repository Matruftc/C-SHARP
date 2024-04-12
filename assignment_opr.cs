using System;

class assignment_opr{

    public static void Main (string[] args)
    {
        int num1 = 10;

        int ass = 2;
        ass += num1;
        Console.WriteLine(ass);

        int ass1 = 2;
        ass1 -= num1;
        Console.WriteLine(ass1);

        int ass2 = 2;
        ass2 *= num1;
        Console.WriteLine(ass2);
    }
}