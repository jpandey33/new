using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newgit
{
    public class Program
    {
        static void Main(string[] args)
        {
            Boy obj = new Boy();

            Boy obj2 = new Boy("Raj");
            Boy obj1 = new Boy(21);
            Boy obj3 = new Boy(2, 3);
            Boy obj4 = new Boy(4, 5, 6);
            //Console.WriteLine(obj.Boy());
            Console.ReadKey();
        }
    }
    public class Boy
    {
        public Boy()
        {
            Console.WriteLine("Jwala");
        }
        public Boy(string a)
        {
            Console.WriteLine(a);
        }
        public Boy(int r)
        {

            Console.WriteLine(r);
        }
        public Boy(int b, int c)
        {
            Console.WriteLine(b + c);
            // Console.WriteLine(c);
        }
        public Boy(int d, int e, int f)
        {
            Console.WriteLine(d * e * f);
        }

    }
}
