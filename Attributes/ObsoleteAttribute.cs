using System;
using System.Collections.Generic;

namespace Advance_CSharp.Attributes
{
    public class ObsoleteAttribute
    {
         /* static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            //cal.add(10,20);
            cal.add(new List<int>(){1,2,3,4,5});
        }*/
    }
}

public class  Calculator
{
    [Obsolete("use add(List<int> Number) method",true)] // 3 overloaded vertion 1.(),2.(message),3(message,true)
    public int add(int a,int b){
        return a+b;
    }

    public int add(List<int> Number){
        int sum = 0;
        foreach(int i in Number){
            sum += i;
        }
        return sum;
    }
}