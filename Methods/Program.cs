namespace pratikler{
 class Program {
         static void  Main(string[] args){
            
            int x=2;
            int y=3;
            Console.WriteLine(x+y);

            int result=sum(x,y);
            Console.WriteLine(result);

            Methods methods=new Methods();
            methods.write(Convert.ToString(result));

            int refResult=methods.increaseSum(ref x, ref y);
            methods.write(Convert.ToString(refResult));
            methods.write(Convert.ToString(x+y));


            methods.Sum(2,3,out int result2);
            Console.WriteLine(result2);

            //Overloading 

            string s="AYCAN";
            int num=99;
            methods.write(num);




        }
        static int sum(int x, int y){
            return x+y;
        }
    }
    class Methods {
        public void write(string s){
            Console.WriteLine(s);        
            }

            public void write(int s){
                Console.WriteLine(s);
            }
            public void write(string s1, string s2){
                Console.WriteLine(s1+s2);
            }

            public int increaseSum(ref int x, ref int y){
                x+=1;
                y+=1;
                return x+y;

            }

            public  void Sum(int a, int b, out int result){
                result=a+b;
            }
    }
        
    


     public static class Extension{

        public static bool CheckSpaces(this string name){
            return name.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string name){
            string[] list=name.Split(" ");
            return string.Join("",list);
        }

        public static string MakeUpperCase(this string param){
            return param.ToUpper();

        }
        public static string MakeLowerCase(this string param){
            return param.ToLower();
        }
    }
    
}