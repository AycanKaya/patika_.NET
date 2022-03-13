using System;
namespace pratikler{
    class Program {
         static void  Main(string[] args){
           
           //Question 1;
            Console.WriteLine("Please Enter the number ; ");
            int x= int.Parse(Console.ReadLine());
            question1(x);
        
            //Question 2;
           Console.WriteLine("Please Enter two number ; ");
            int x= int.Parse(Console.ReadLine());
            int xy= int.Parse(Console.ReadLine());
            question2(x,y);

         }
         static void question1(int n){
                Console.WriteLine("Please enter "+n+" numbers :");
                List<int> numbers=new List<int>();
                while(n>0){
                    int x= int.Parse(Console.ReadLine());
                    numbers.Add(x);
                    n--;
                }

            foreach(var a in numbers){
                if(a%2==0)
                    Console.WriteLine(a);
            }


         }

        static void question2(int n, int m){
             Console.WriteLine("Please enter "+n+" numbers :");
                List<int> numbers=new List<int>();
                while(n>0){
                    int x= int.Parse(Console.ReadLine());
                    numbers.Add(x);
                    n--;
                }

                foreach(var n in numbers){
                    if(n == m || n%m == 0){
                        Console.WriteLine(n);
                    }
                }
        }

        static void question3(int n){
            Console.WriteLine("Please enter "+n+" words :");
                List<string> words=new List<string>();
                while(n>0){
                    string x= Console.ReadLine();
                    words.Add(x);
                    n--;
                }

                words.Reverse();
                foreach(var na in words){
                    Console.WriteLine(na);
                }
        }
        static void question4(){
            Console.WriteLine("Enter the sentences.");
           string c=Console.ReadLine();
           string[] words=c.Split(" ");
            Console.WriteLine(words.Length);
            
           int size=0;
           for(int i=0; i < words.Length ;i++){
                size+=words[i].Length;
           }
           Console.WriteLine(size);
        }




    }
    

    
}