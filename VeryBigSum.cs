using System;
using System.Collections.Generic;
namespace problem_solving {

    public class VeryBigSum {


        public long aVeryBigSum(long[] ar) {

            long result = 0;


            foreach(long i in ar){
                result += i;
            }

            return result;
        }
    }
}