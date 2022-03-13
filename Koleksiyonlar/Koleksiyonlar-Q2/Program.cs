using System;
namespace Koleksiyonlar{
    class Program
    {
        public static void Main(string[] args)
        {
            n=20;
            int[] arr=new int[20];
            while(n > 0){
                 int x = int.Parse(Console.ReadLine());
                    arr.add(x);
                 
            }

            
           Array.Sort(arr);
           Console.WriteLine(arr[0].ToString()+" "+arr[1].ToString()+" "+arr[2].ToString());
           Console.WriteLine("Average :"+(arr[0]+arr[1]+arr[2]/3));
           Array.Reverse(arr);
           Console.WriteLine(arr[0].ToString()+" "+arr[1].ToString()+" "+arr[2].ToString());
           Console.WriteLine("Average :"+(arr[0]+arr[1]+arr[2]/3));

           

        }
    }
}