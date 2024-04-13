using System;

class arrayy{
    public static void Main(string[] args)
    {
        int[] marks = {10,12,2,3,45,54};

        foreach(int i in marks) 
        {
            Console.WriteLine("Values are:"+marks[i]);
        }
    }
}