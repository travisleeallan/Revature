using System;

namespace StringCat
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string word1 = args[0];
            string word2 = args[1];
            var word3;
            int wlength = 0;
            Console.WriteLine("1:{0}\n2:{1}", word1, word2); //test

            //string comparison longer yeilds len

            for (int i = 0; i < wlength; i++)
            {
                if (i < String.len(word1) && i < String.len(word2))
                {

                }
                Console.WriteLine("{0},{1}", word1[i], word2[i]);
            }
        }
    }
}
