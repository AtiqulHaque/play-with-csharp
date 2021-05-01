using System.Collections.Generic;

namespace problem_solving
{
    class BirthdayCake {

        /*
         * Complete the 'birthdayCakeCandles' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY candles as parameter.
         */

        public static int birthdayCakeCandles (List<int> candles) {
            
            Dictionary<int, int> continer = new Dictionary<int, int> ();
            int maxKey = 0;
            int maxVal = 0;
            
            foreach (int i in candles) {
                if (continer.ContainsKey (i)) {
                    continer[i] += 1;
                } else {
                    continer.Add (i, 1);
                }
            }
        

            foreach(var key in continer){
                if(maxKey == 0 || key.Key > maxKey ){
                    maxKey = key.Key;
                    maxVal = key.Value;
                    continue;
                }
            }


            return maxVal;
        }

    }
}