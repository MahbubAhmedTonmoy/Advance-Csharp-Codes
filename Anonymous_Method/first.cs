using System;


/*delegate void NumberChanger(int n);
...
NumberChanger nc = delegate(int x) {
   Console.WriteLine("Anonymous Method: {0}", x);
}; */


delegate void NumberChanger(int n);
namespace Advance_CSharp.Anonymous_Method
{
    public class first
    {
        static int n = 10;
        public static void add(int x){
            n +=x;
            Console.WriteLine(n);
        }
         public static void mul(int x){
            n *=x;
            Console.WriteLine(n);
        }

        /* 
            static void Main(){
           NumberChanger nc = delegate(int x) {
            Console.WriteLine("Anonymous Method: {0}", x);
         };
            nc(10);
            nc = new NumberChanger(add);
            nc(5);
        }
        }
         */
    }
}