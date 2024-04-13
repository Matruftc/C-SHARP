using System;

class orgm{

public void show(ref int num1){

         num1 += num1;
         Console.WriteLine(num1);
      
}

public static void main(string[] args)
    {
      int num1 = 100;
     orgm o = new orgm();

      Console.WriteLine("function before calling"+num1);

       o.show(ref num1);

       Console.WriteLine("function after calling"+num1);

      
    }
}