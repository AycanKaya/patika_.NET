using System;
namespace Koleksiyonlar
{
    class Program
    {
        public static void Main(string[] args)
        {
           string sesli="aeioöuü";
           string n="Aycan ile ";
            int temp=0;
            List<char> ss=new List<char>();
            for(int i=0;i < n.Length;i++){
               if(sesli.Contains(n[i])){
                    temp++;
                    ss.Add(n[i]);
               }
           }
        
           

        }
    }
}