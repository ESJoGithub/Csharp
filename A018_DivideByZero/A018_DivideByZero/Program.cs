using System;
namespace A018_DivideByZero
{
    class Programs
    {
        static void Main(string[] args)
        {
            int x = 10; int y = 0;
            try
            {
                Console.WriteLine(x/y);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}