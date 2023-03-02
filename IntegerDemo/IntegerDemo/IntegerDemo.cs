using System;

class  IntgerDemo
{
    static void Main(string[] args)
    {
        int number = 1_234;
        Console.WriteLine("{0}", number);

        int min = Int32.MinValue; 
        int max = Int32.MaxValue;
        sbyte sb = sbyte.MaxValue;
        short st = short.MaxValue;  
        long l = long.MaxValue; 
        Console.WriteLine("int 변수의 최소값: {0}", min);
        Console.WriteLine("int 변수의 최대값: {0}", max);
        Console.WriteLine("sbyte 변수의 최대값: {0}", sb);
        Console.WriteLine("short 변수의 최대값: {0}", st);
        Console.WriteLine("long 변수의 최대값: {0}", l);
    }

}