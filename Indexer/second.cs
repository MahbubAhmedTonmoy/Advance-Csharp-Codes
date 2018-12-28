namespace Advance_CSharp.Indexer
{
    public class second
    {
       /*  static void Main(){
            Student s = new Student(1,"m");
            Console.WriteLine(s[0]);
            Console.WriteLine(s[1]);
            s[0] = 101;
            s[1]="tonmoy";
            Console.WriteLine(s.name);
        }

        }*/
    }
}

public class Student
{
    public int id{get;set;}
    public string name{get;set;}

    public Student(int id,string name){
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