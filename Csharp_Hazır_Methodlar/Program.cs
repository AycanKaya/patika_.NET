using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
      int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; ++i)
        {
            string sentence = Console.ReadLine();
            string even = "";
            string odd = "";
         
            for (int j = 0; j < sentence.Length - 1; j += 2)
            {
                even += sentence[j];
                odd += sentence[j + 1];
            }

         
            if (sentence.Length % 2 != 0)
            {
                even += sentence[sentence.Length - 1];    
            }
            
            Console.WriteLine("{0} {1}", even, odd);
        }
    
        
    }
}