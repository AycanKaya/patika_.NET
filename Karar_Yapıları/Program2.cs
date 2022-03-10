using System;

namespace Karar_Yapıları{

    class Program2{
         static void Main(string[] args){
            int month=DateTime.Now.Month;

            switch(month){
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                default:
                    Console.WriteLine("Geçersiz ay");
                    break;

            }

            switch(month){
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Ayındasınız");
                    break;

            }


        }
    }

}
