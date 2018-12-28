#define In
using System;
using System.Diagnostics;

namespace Advance_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Reflection.MemberInfo info= typeof(MyClass);
            object [] a = info.GetCustomAttributes(true);

            for(int i=0;i<a.Length;i++){
                Console.WriteLine(a[i]);
            }

            student s = new student(1,"m");
            Console.WriteLine(s[0]);
            Console.WriteLine(s[1]);
            s[0] = 101;
            s[1]="tonmoy";
            Console.WriteLine(s.name);
        }
    }
}

[AttributeUsage(AttributeTargets.All)]
public class  HelpAttribute: System.Attribute
{
    public readonly string url;
    public string topic{get;set;}

    public HelpAttribute(string url){
        this.url = url;
    }
}

[HelpAttribute("Information on the class MyClass")]
class MyClass{

}

public class student
{
    public int id{get;set;}
    public string name{get;set;}

    public student(int id,string name){
        this.id = id;
        this.name = name;
    }

    public object this[int index]{
        get{
            if(index == 0) return id;
            else if(index == 1) return name;
            return null;
        }
        set{
            if(index == 0) id = (int)value;
            if(index == 1) name = (string)value;
        }
    }
    
}