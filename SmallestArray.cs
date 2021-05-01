using System;
namespace problem_solving {
    public class SmallestArray {
        public void calculate () {
            int[] numbers = new int[] {3, 4, 1, 1, 6 };

            int startIndex = 0;
            int minResult = 100000000;
            int minLength = 0;
            int minSum = 0;
            int requiredSum = 8;

            for (int i = 0; i < numbers.Length; i++) {
                minSum += numbers[i];
                minLength++;

                while (minSum >= requiredSum && startIndex < numbers.Length) {
                    minSum -= numbers[startIndex++];
                    minLength--;                   
               
                    if(minSum >= requiredSum){
                        minResult = Math.Min(minResult, minLength);
                    }
                }
            }
            
            System.Console.WriteLine(minResult);
        }
    }
}