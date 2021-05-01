using System;
using System.Text.RegularExpressions;
namespace problem_solving {
    public class PlusMinus {
        public static void Convert() {
            
            int [] arr = new int[6]{-4, 3, -9, 0, 4, 1};

            float countPlus = 0;
            float countMinus = 0;
            float countZero = 0;

            foreach(int eachar in arr){
                if(eachar == 0) countZero += 1;
                else if(eachar < 0) countMinus += 1;
                else if(eachar > 0) countPlus += 1;
            }

            System.Console.WriteLine(string.Format("{0:F6}", 1 / (arr.Length / countPlus)));
            System.Console.WriteLine(string.Format("{0:F6}", 1 / (arr.Length / countMinus)));
            System.Console.WriteLine(string.Format("{0:F6}", 1 / (arr.Length / countZero)));
        }
    }
}