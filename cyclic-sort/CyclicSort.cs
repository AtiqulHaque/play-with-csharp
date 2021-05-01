using System.Collections.Generic;
namespace problem_solving.cyclic_sort {
    public class CyclicSort {
        public void calculate () {
            int[] inputArray = new int[] {
                2,
                3,
                1,
                8,
                2,
                3,
                5,
                1
            };

            Dictionary<int, int> hashMap = new Dictionary<int, int> ();

            for (int i = 0; i < inputArray.Length; i++) {
                if (hashMap.ContainsKey (inputArray[i])) {
                    hashMap[inputArray[i]] = hashMap[inputArray[i]] + 1;
                } else {
                    hashMap[inputArray[i]] = 1;
                }
            }

            int loop = 0;
            int temp = 0;

            while (loop < inputArray.Length) {
                while (true) {
                    if ((hashMap.ContainsKey (inputArray[loop]) && hashMap[inputArray[loop]] == 0) || inputArray[loop] == loop + 1) {
                        loop++;
                        break;
                    } else {
                        if (hashMap.ContainsKey (inputArray[loop])) {
                            hashMap[inputArray[loop]] = 0;
                        }
                        temp = inputArray[inputArray[loop] - 1];
                        inputArray[inputArray[loop] - 1] = inputArray[loop];
                        inputArray[loop] = temp;
                    }
                }
            }

            for (int i = 0; i < inputArray.Length; i++) {
                System.Console.WriteLine (inputArray[i]);
            }
        }
    }
}