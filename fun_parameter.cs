using System;

class orgm{

public int show(int num){
    Console.WriteLine("Hello i am a function with the output"+num);
}

public static void main(string[] args)
    {
       orgm o = new orgm();
       o.show(10);
    }
}