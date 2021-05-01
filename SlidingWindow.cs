using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace problem_solving {
    public class SlidingWindow {
        public void calculate () {
            string str = "cbbebi";
            int k = 3;
            int n = str.Length;
            Dictionary<string, int> hashMap = new Dictionary<string, int> ();
            List<string> window = new List<string> { };
            int i = 0;
            int maxLength = 0;

            while (hashMap.Count != k) {
                if (!hashMap.ContainsKey (str[i].ToString ())) {
                    hashMap[str[i].ToString ()] = 1;
                } else {
                    hashMap[str[i].ToString ()] += 1;
                }
                window.Add (str[i].ToString ());
                i++;
            }

            for (int end = window.Count; end < n; end++) {
                
                if (hashMap.ContainsKey (str[end].ToString ())) {
                    hashMap[str[end].ToString ()] += 1;
                    window.Add (str[end].ToString ());
                    maxLength = Math.Max (maxLength, window.Count);
                } else {
                    hashMap[str[end].ToString ()] = 1;
                    while (hashMap.Count != k) {
                        string last = window[0];
                        window.RemoveAt (0);
                        if (hashMap[last] <= 1) {
                            hashMap.Remove (last);
                        } else {
                            hashMap[last] -= 1;
                        }
                    }
                }
            }

            System.Console.WriteLine(maxLength);

        }
    }
}