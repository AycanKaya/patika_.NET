using System;

namespace console_programlama{
    
class Program{

    public static void Main(string[] args){

        Console.WriteLine("İsim ve Soyisim giriniz.");
  //      string name= Console.ReadLine();
   //     string surname=Console.ReadLine();
     //   Console.WriteLine(name+" "+surname);


        var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
        Console.WriteLine(date1);

        int num=1;
        int num2=2;
        int a= num+num2;

        string str20="20";
        int x=20;
        int y=x+int.Parse(str20);

        bool isSucces=true;
        bool isCompleted=false;

        if(isSucces || isCompleted) {Console.WriteLine("Normall");}
        if(isSucces && isCompleted) {Console.WriteLine("Great");}
        if(!(isSucces || isCompleted)) {Console.WriteLine("Bad");}

        //***********Implicit Conversion

        byte b=9;
        sbyte c=8;
        short s=4;
        int d=b+c+s;
        Console.WriteLine("d: "+d);

        long h=d;
        Console.WriteLine("h:"+h);
        char f = 'k';
        object o=f+h;
        Console.WriteLine("o:"+o);

        //**********Explicit Conversion

        int ı=4;
        byte yb=((byte)ı);

        string ss=ı.ToString();
        string zz=14.5f.ToString();


    

    }
    /*
        Task
        Given the meal price (base cost of a meal), tip percent (the percentage of the meal price being added as tip), 
        and tax percent (the percentage of the meal price being added as tax) for a meal, find and print the meal's total cost. 
        Round the result to the nearest integer.
    */
    public static void solve(double meal_cost, int tip_percent, int tax_percent){


    double tip=tip_percent*meal_cost/100;
    double tax=tax_percent*meal_cost/100;
    double total=meal_cost+tip+tax;
    Console.WriteLine(Math.Round(total));
    
    

}

}
    

}
