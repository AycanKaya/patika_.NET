﻿namespace Döngüler{

    class Program{

        public static async void Main(string[] args){

           Console.Write("Please Enter a number");
           int temp=int.Parse(Console.ReadLine());
           for(int i=1;i<=temp;i++){
               if(i%2==1){
                   Console.WriteLine(i);
               }
           }

           int odd=0;
           int even=0;
           for(int i=1;i<=1000;i++){
               if(i%2==0)
                even++;
               else
                odd++;
           }
        
        Console.WriteLine("Count of odd numbers:"+odd);
        Console.WriteLine("Count of even numbers:"+even);

        for (int i=1; i<10;i++){
            if(i==4)
                break;
            Console.WriteLine("i");
        }



        }



    }



}