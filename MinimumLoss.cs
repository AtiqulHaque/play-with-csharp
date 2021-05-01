using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;
namespace problem_solving {
    public class MinimumLoss {
        public static int calculate (long[] price) {

            Dictionary<long,int> mem = new Dictionary<long, int>();

            for(int i = 0; i < price.LongLength; i++){
                mem[price[i]] = i;
            }
            
           
            Array.Sort(price,(a, b) => b.CompareTo(a)); 

            long minloss = 500000000;

            for(int i = 0; i < price.LongLength -1; i++){
                if((price[i] - price[i+1]) < minloss){
                    if(mem[price[i]] < mem[price[i + 1]]){
                       minloss = price[i] - price[i+1]; 
                    }
                } 
            }

            return Convert.ToInt32(minloss);
        }
    }
}