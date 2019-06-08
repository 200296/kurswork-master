using System;


namespace kurswork2
{
   public class Program
    {        
        public static int Put(int v, int t)
        {
            if (t < 0)
            {
                Console.WriteLine("error");

                return 0;
            } 
            else
            { Console.WriteLine("true, s=",  v * t); }
            return v * t;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Put(2,3));
            Console.WriteLine(Put(2, -3));
            Console.ReadKey();
        }
    }
}
