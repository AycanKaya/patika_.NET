using System;
namespace hata_yönetimi
{
    class Program{
        public static void Main(string[] args){
        
            try{
                int a = int.Parse(Console.ReadLine());

                int b = int.Parse(Console.ReadLine());

                int c = a+b;

                Console.WriteLine(c);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Bir Hata Oluştu: "+ ex.Message);
            }
            
            finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }




            try
            {
                int a=int.Parse(null);
            }
            catch (ArgumentNullException ex)
            {
                
                Console.WriteLine("Boş değer atayamazsınız.");
                Console.WriteLine(ex);
            }catch(FormatException ex){

                Console.WriteLine("Uyumsuz veri tipi.");
                Console.WriteLine(ex);

            }catch(OverflowException o){
                Console.WriteLine("Çok büyük ya da çok küçük bir değer girdiniz.");
                Console.WriteLine(o);
            }





        }
    }
}
