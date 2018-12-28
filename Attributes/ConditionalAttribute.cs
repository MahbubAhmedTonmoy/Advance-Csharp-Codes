#define In
using System;
using System.Diagnostics;

namespace Advance_CSharp.Attributes
{
    public class ConditionalAttribute
    {
       /* static void Main(string[] args)
        {
            person p = new person();
            p.show("mahbub");
        }*/
    }
}
class person{
    [Conditional("In")]
    public void show(string name){
        Console.WriteLine("name is " + name);
    }
    public void withoutCOndition(){
        Console.WriteLine("name is not print if comment out #define message");
    }
}