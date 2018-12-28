using System;

namespace Advance_CSharp.Delegate
{
    delegate int numberchange(int n);
    public class first
    {
        public static int n = 10;

    public static int AddNum(int p){
        n += p;
        return n;
    }
    public static int MulNum(int q){
        n *= q;
        return n;
    }
    public static void print(){
        Console.WriteLine("number : {0}",n);
    }
        /* static void Main(){
            
            numberchange nc1 = new numberchange(AddNum);
            numberchange nc2 = new numberchange(MulNum);
            nc1(10);
            print();
            nc2(10);
            print();
            
        }*/
    }
}

