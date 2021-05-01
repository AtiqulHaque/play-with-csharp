using System;
using System.Collections.Generic;
namespace problem_solving
{
    public class MissingNumbers
    {
        public static int[] Calculate(int[] arr, int[] brr)
        {
            Dictionary<int,int> arrFrequecy = new  Dictionary<int,int>(); 
            Dictionary<int,int> brrFrequecy = new  Dictionary<int,int>(); 
            
            List<int> result = new List<int>();
            
            foreach(int i in arr){
                if(arrFrequecy.ContainsKey(i)){
                    arrFrequecy[i] += 1; 
                } else{
                    arrFrequecy[i] = 1;
                }
            }
            
            foreach(int i in brr){
                if(brrFrequecy.ContainsKey(i)){
                    brrFrequecy[i] += 1; 
                } else{
                    brrFrequecy[i] = 1;
                }
            }  


            foreach( var data in brrFrequecy ){
                  if(arrFrequecy.ContainsKey(data.Key)){
                      if(arrFrequecy[data.Key] != data.Value){
                        result.Add(data.Key);            
                      }
                  } else{
                        result.Add(data.Key);           
                  }  
            }
            result.Sort();
            return result.ToArray();
           
        }
    }
}