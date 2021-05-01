using System.Collections.Generic;
namespace problem_solving {
    public class ArraySearch {
        public void calculate () {
            int [] inputArray = new int[]{
                1, 7, 5, 9, 2, 12, 3
            };

            Dictionary<int,bool> hashCode = new Dictionary<int,bool>();

            foreach(int m in inputArray){
                hashCode[m] = false;    
            }

            int k = 2;
            int countDifference = 0;

            for(int i = 0; i < inputArray.Length; i++){

               int  z =  inputArray[i] - k;
               
               if(z < 0){
                    z = z * -1;
               }
               if(hashCode.ContainsKey(z) && !hashCode[z]){
                    countDifference++;
                    hashCode[z] = true;
               }
            }

            System.Console.WriteLine(countDifference);

        }
    }
}