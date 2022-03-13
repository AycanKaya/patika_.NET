using System;
namespace Sınıf_Yapısı{
/*
 Public : Her yerden erişilebilir.

 Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.

 Internal : Sadece bulunduğu proje içerisinden erişilebilir
 
 Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
*/

    class Program{
        public static void Main(string[] args){
            Worker w1 = new Worker();
            w1.name = "ayse";
            w1.surname = "kara";
            w1.no = 551651;
            w1.department = "Purchase department";

            w1.workerInfo();
        }
        }

        class Worker
    {
        public string name;
        public string surname;
        public int no;

        public string department;

        public void workerInfo()
        {
            Console.WriteLine("Worker name: " + name);
            Console.WriteLine("Worker surname: " + surname);
            Console.WriteLine("Worker no: " + no);
            Console.WriteLine("Worker department: " + department);
        }

    }
    
}