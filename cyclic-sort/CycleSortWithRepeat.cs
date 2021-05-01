using System;
using System.Collections.Generic;

namespace problem_solving
{
    public class CycleSortWithRepeat
    {
        public void SortData(int [] numbers){
        
            int loop = 0; 
            int count = numbers.Length - 1;
            Dictionary<int, int> repeatItems = new Dictionary<int, int>();  
            
            while (true)
            {
                
                if (loop > count)
                {
                    break;
                }
                if (numbers[loop] == (loop + 1))
                {
                    loop++;
                }
                else
                {
                    int temp = numbers[numbers[loop] - 1];
                    if (temp == numbers[loop])
                    {
                        loop++;
                        if (repeatItems.ContainsKey(temp) == false)
                        {
                            repeatItems[temp] = temp;
                        }
                        continue;
                    }
                    numbers[numbers[loop] - 1] = numbers[loop];
                    numbers[loop] = temp;
                }
            }

            foreach (var item in repeatItems)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}