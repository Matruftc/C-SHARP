using System;

class orgm{

public int show(int num){

        int num1 = 10;
        int res = num1 * num;
        return res;
      
}

public static void main(string[] args)
    {

     orgm o = new orgm();
      int result = o.show(10);

       Console.WriteLine(result);
    }
}