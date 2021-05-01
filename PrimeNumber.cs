using System;
using System.Collections.Generic;

namespace problem_solving {
    public class PrimeNumber {
        public static int calculate (int n) {
            int countPrime = 0;
            Dictionary<int, bool> hashMap = new Dictionary<int, bool> ();

            for (int j = 2; j < n; j++) {
                hashMap[j] = true;
            }

            for (int i = 2; i < Math.Sqrt (n); i++) {

                if (!hashMap[i])
                    continue;

                for (int j = i + i; j < n; j += i) {
                    hashMap[j] = false;
                }
            }

            for (int k = 2; k < n; k++) {
                if (hashMap[k]) {
                    countPrime++;
                }
            }

            return countPrime;
        }
    }
}