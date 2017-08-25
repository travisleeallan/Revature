using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int buzz = 0;
            int fizzBuzz = 0;
            int neither = 0;
        
            for(int i=1; i <=100; i++) {
                if (i % 3 == 0) {
                    buzz = buzz + 1;
                }
                else if (i % 5 == 0) {
                    fizzBuzz++;
                }
                else {
                    neither++;
                }
            }
            Console.WriteLine("buzz = {0}", buzz);
            Console.WriteLine("fizzBuzz = {0}", fizzBuzz);
        }
    }
}
