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




        }
        static int sum(int x, int y){
            return x+y;
        }
    }
    class Methods {
        public void write(string s){
            Console.WriteLine(s);        
            }

            public int increaseSum(ref int x, ref int y){
                x+=1;
                y+=1;
                return x+y;

            }
    }
    
}