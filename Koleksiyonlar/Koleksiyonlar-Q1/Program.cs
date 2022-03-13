using  System;
namespace Koleksiyonlar{
    class Program{
        public static void Main(string[] args){
            
            n=20;
            arraylist arr=new arraylist();
            while(n > 0){
                 int x = int.Parse(Console.ReadLine());
                 bool isn=int.TryParse(x);
                 if(x>0 && !isn){
                    arr.add(x);
                 }
            }

            arr=arr.Sort();
            foreach(var e in arr){
                Console.WriteLine(e);
            }
            





        }

        
    }
}