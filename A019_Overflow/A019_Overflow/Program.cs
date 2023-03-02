using System;
namespace A019_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int.Maxvalue = {int.MaxValue}");

            int x = int.MaxValue;
            int y = 0;

            // int y = int.MaxValue + 10; 
            // 이런 식은 이미 연산 결과가 int 범위를 넘어서는 것이 명확하여 컴파일 에러가 발생함

            checked 
            {
                try
                {
                    y = x + 10;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message );
                }
            }
            Console.WriteLine($"int.MaxValue + 10 = {y}");

        }
    }
}