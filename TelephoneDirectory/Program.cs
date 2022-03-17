namespace TelephoneDirectory
{
    //Console Telefon Rehberi Uygulaması
    class Program  {
         public static void Main(string[] args){
            
             Phone phone1=new Phone(LongRandom(10000000000, 10000000050, new Random()),"Person 1");
             Phone phone2=new Phone(LongRandom(10000000000, 10000000050, new Random()),"Person 1");
             Phone phone3=new Phone(LongRandom(10000000000, 10000000050, new Random()),"Person 1");
             Phone phone4=new Phone(LongRandom(10000000000, 10000000050, new Random()),"Person 1");
             Phone phone5=new Phone(LongRandom(10000000000, 10000000050, new Random()),"Person 1");
                 TelephponeBook telephponeBook=new  TelephponeBook();
                 telephponeBook.addNum(phone1);
                 telephponeBook.addNum(phone2);
                 telephponeBook.addNum(phone3);
                 telephponeBook.addNum(phone4);
                 telephponeBook.addNum(phone5);
                
                int choise = ConsoleQ();
                switch(choise){
                    case 1 :
                        newNum(telephponeBook);
                        break;
                    case 2 :
                        deleteNum(telephponeBook);
                        break;
                    case 3: 
                        updateNum(telephponeBook);
                        break;
                    case 4:
                        writeAllNum(telephponeBook);
                        break;
                    case 5 :
                        callPhone(telephponeBook);
                        break;
                                    }

           

         }
         static long LongRandom(long min, long max, Random rand) {
            long result = rand.Next((Int32)(min >> 32), (Int32)(max >> 32));
            result = (result << 32);
            result = result | (long)rand.Next((Int32)min, (Int32)max);
            return result;
}

        static int ConsoleQ(){
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz"+
                                "*******************************************"+"/n"+);
            Console.WriteLine("(1) Yeni Numara Kaydetmek"+ "/n"+
                               " (2) Varolan Numarayı Silmek"+"/n"+
                               "(3) Varolan Numarayı Güncelleme"+"/n"+
                                "(4) Rehberi Listelemek"+"/n"+
                                "(5) Rehberde Arama Yapmak ?");
            return int.Parse(Console.ReadLine());
        }
        static void newNum(TelephponeBook telephponeBook){
            Console.WriteLine("Lütfen isim ve soy isim giriniz. ");
            string name = Console.ReadLine();
            Console.WriteLine("Telefon numarasını giriniz :  ");
            long num= long.Parse(Console.ReadLine());
            Phone p=new Phone(num,name);
            telephponeBook.addNum(p);
            Console.WriteLine("İşlem Başarılı.");
        }
        static void deleteNum(TelephponeBook  telephponeBook){
            Console.WriteLine("Telefon numarasını silmek istediğiniz kişinin kayıtlı adını giriniz. ");
            string s=Console.ReadLine();
            if(telephponeBook.isthere(s)==null){
                Console.WriteLine("Lütfen geçerli bir isim giriniz. Aşağıdaki listeye bakın.");
            }
            writeAllNum(telephponeBook);
            Console.WriteLine("Telefon numarasını silmek istediğiniz kişinin kayıtlı adını giriniz. ");
            s=Console.ReadLine();
            while(telephponeBook.isthere != null ){
                telephponeBook.deleteNum(telephponeBook.isthere(s));
                Console.WriteLine("İşlem başarılı .");
                break;
            }


        }
        static void updateNum(TelephponeBook telephponeBook){
            Console.WriteLine("Telefon numarasını güncellemek istediğiniz kişinin kayıtlı adını giriniz. ");
            string s=Console.ReadLine();
            if(telephponeBook.isthere(s)==null){
                Console.WriteLine("Lütfen geçerli bir isim giriniz. Aşağıdaki listeye bakın.");
            }
            writeAllNum(telephponeBook);
            Console.WriteLine("Telefon numarasını güncellemek istediğiniz kişinin kayıtlı adını giriniz. ");
            s=Console.ReadLine();
            if(telephponeBook.isthere(s)!=null){
                telephponeBook.isthere(s).num=long.Parse(Console.ReadLine());
                Console.WriteLine("İşlem Başarılı. Kontrol ediniz . ");
                writeAllNum(telephponeBook);
            }

        }
        static void callPhone(TelephponeBook telephponeBook){
            Console.WriteLine("Aramak istediğiniz numara : ");
            long num= long.Parse(Console.ReadLine());
            if(telephponeBook.istherePhone(num)!= null){
                Console.WriteLine(telephponeBook.istherePhone(num).person_name+" arandı.");
            }
        }
        static  void writeAllNum(TelephponeBook telephponeBook){
            List<Phone> l= telephponeBook.Get_all_phones;
            foreach( var i in l){
                Console.WriteLine(i.person_name+" : "+i.num);
            }
        }


    }
    /*
    Telefon Numarası Kaydet
    Telefon Numarası Sil
    Telefon Numarası Güncelle
    Rehber Listeleme (A-Z, Z-A seçimli)
    Rehberde Arama
    */
    class TelephponeBook{

        protected List<Phone> allPhones;

        public  TelephponeBook(){
            allPhones =new List<Phone>();
        }

        public void addNum(Phone phone){
            allPhones.Add(phone);
        }
        public void deleteNum(Phone phone){
            allPhones.Remove(phone);
        }

        public List<Phone> Get_all_phones{
            get{return allPhones;}
        }
        public Phone isthere(string name){
           foreach (var phone in allPhones){
               if(phone.person_name == name)
                    return phone;
           }
           return null;
        }
        public Phone istherePhone(long num){
           foreach (var phone in allPhones){
               if(phone.num == num)
                    return phone;
           }
           return null;
        }
             



    } 
    class Phone{
         public long num; // field
         public string person_name;

         public Phone(long num, string person_name){  
            this.num=num;
            this.person_name=person_name;
         }

        public long Num   // property
         {
             get { return num; }   // get method
             set { num = value; }  // set method
        }

        public string Person_Name   // property
         {
             get { return person_name; }   // get method
             set { person_name = value; }  // set method
        }

           
       
    }




}