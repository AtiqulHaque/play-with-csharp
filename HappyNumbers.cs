using System;
using System.Collections.Generic;
namespace problem_solving
{
    public class HappyNumbers
    {
        public static bool IsHappy (int n) {
            // string strNumber = n.ToString ();
            // Dictionary<int, int> hashMap = new Dictionary<int, int>();
            // int temp = n;
            // while (true) {
            //     int result = 0;
            //     string digits = temp.ToString();

            //     for (int i = 0; i < digits.Length; i++) {
            //         result += Convert.ToInt32(digits[i].ToString()) * Convert.ToInt32(digits[i].ToString());                    
            //     }

            //     if(hashMap.ContainsKey(result)){
            //         System.Console.WriteLine(result);
            //         return false;
            //     } else{
            //         hashMap.Add(result,result);
            //     }

            //     if (result == 1) {
            //         return true;
            //     } else {
            //         temp = result;
            //         result = 0;
            //     }

            // }

             return false;
        }
    }
}