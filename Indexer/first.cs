using System;

namespace Advance_CSharp.Indexer
{
    public class first
    {
        /* static void Main(string[] args) {
         name names = new name();
         names[0] = "Zara";
         names[1] = "Riz";
         names[2] = "Nuha";
         names[3] = "Asif";
         names[4] = "Davinder";
         names[5] = "Sunil";
         names[6] = "Rubic";
         
         //using the first indexer with int parameter
         for (int i = 0; i < name.size; i++) {
            Console.WriteLine(names[i]);
         }
         
         //using the second indexer with the string parameter
         Console.WriteLine(names["Nuha"]);
         Console.ReadKey();*/
    }
}

class name
{
    static public int size = 10;
    private string[] namelist = new string[size];

    public name(){
        for(int i=0;i<size;i++){
            namelist[i] = "N.A.";
        }
    }

    public string this[int index]{
        
        get{
            string temp;
            if(index>=0 && index<=size-1){
                temp = namelist[index];
            }
            else{
                temp = "";
            }
            return temp;
        }
        set{
            if(index>=0 && index<=size-1){
                namelist[index] = value;
            }
        }
    }

    public int this[string name]
    {
        get { 
            int i = 0;
            while(i<size){
                if(namelist[i]==name){
                    return i;
                }
                i++;
            }
            return i; 
        }
    }
}
