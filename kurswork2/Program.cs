using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurswork2
{
   public class Program
    {
        
        public static int Put(int v, int t)
        {
            int s;
            s = v * t;
            if (t < 0)
            {
                Console.WriteLine("error");

                return 0;
            } 

            else
            {
                Console.WriteLine("true, s=", s);
            }
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
