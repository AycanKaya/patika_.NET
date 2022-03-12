using System;
namespace pratikler {
    class Program{
        public static void Main(string[] args){
            string[] colors=new String[5];
            string[] animals={"Dog","Cat","Snake", "Bird"};

            Console.WriteLine("Please enter the count of element");
            int lengthDizi=int.Parse(Console.ReadLine());
            int[] numberArr=new int[lengthDizi];
            int sum=0;
            foreach(var n in numberArr)
                sum+=n;
            Console.WriteLine("Average : "+sum/numberArr);
                



        }
    }
}