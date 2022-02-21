using System;

namespace ConsoleApp9
{
   class emply
    {
        public int a;
        public int b;

        public void data(int a,int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("A=" + a);
            Console.WriteLine("B=" + b);
            Console.WriteLine(a + b);

        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            emply obj = new emply();
            obj.data(10, 20);
        }
    }
}
