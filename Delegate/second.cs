using System;
namespace Advance_CSharp.Delegate
{
    public delegate void AddDelegate(int a,int b);
    public class second
    {
       /*  static void Main(){
            math n = new math();

            AddDelegate ad = new AddDelegate(n.add);
            ad.Invoke(1,2);
        }*/
    }
}

class math{
    public int a{get;set;}
    public int b{get;set;}

    public void add(int a,int b){
        Console.WriteLine("sum "+(a+b));
    }
}