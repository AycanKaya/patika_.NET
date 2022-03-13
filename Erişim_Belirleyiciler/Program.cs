using System;
namespace Erişim_Belirleyiciler{
    class Program
    {
        public static void Main(string[] args)
        {
            Worker w1 = new Worker("Ayse", "Yilmaz", 51515, "Help department");
            Worker w2 = new Worker("Okan", "Yilmaz");
            Worker w3 = new Worker();
            w1.workerInfo();
            w2.workerInfo();
            w3.workerInfo();
        }
    }
    class Worker
    {
        public string name;
        public string surname;
        public int no;

        public string department;

        public Worker(string name, string surname, int no, string department)
        {
            this.name = name;
            this.surname = surname;
            this.no = no;
            this.department = department;
        }
        public Worker(string name, string surname)
        {
            this.name = name;
            this.surname = surname;

        }
        public Worker()
        {

        }

        public void workerInfo()
        {
            Console.WriteLine("Worker name: " + name);
            Console.WriteLine("Worker surname: " + surname);
            Console.WriteLine("Worker no: " + no);
            Console.WriteLine("Worker department: " + department);
        }

    }
}
