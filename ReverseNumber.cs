using System;

namespace problem_solving {
    public class ReverseNumber {

        // public static int Reverse (int x) {

        //     bool isNegative = false;
        //     if (x < 0) {
        //         x = x * -1;
        //         isNegative = true;
        //     }
        //     int rev_number = 0;

        //     while (x > 0) {
        //         try {
        //             checked {
        //                 rev_number = rev_number * 10 + x % 10;
        //                 x = x / 10;
        //             }

        //         } catch (OverflowException e) {
        //             return 0;
        //         }

        //     }

        //     if (isNegative) {
        //         rev_number = rev_number * -1;
        //     }

        //     return rev_number;
        // }

        public static int strinToInt (string str) {

            int result = 0;
            bool isNegative = false;
            for (int i = 0; i < str.Length; i++) 
            {
                if(result == 0 && (int) str[i] == 72){
                    isNegative = true;
                }

                if ((int) str[i] >= 48 && (int) str[i] <= 57)
                {
                    try {
                        checked {
                            result = int.Parse ( result.ToString() + str[i].ToString ());
                        }
                    } catch (OverflowException e) {
                        System.Console.WriteLine(e.Message);
                        return result;
                    }
                }
            }

            if(isNegative) 
                result = result * -1;

            return result ;
        }
    }
}