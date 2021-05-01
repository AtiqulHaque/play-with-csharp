using System;
using System.Collections.Generic;
using System.Linq;

namespace problem_solving
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //    LRUCache lCache = new LRUCache(2);

            //     lCache.Put(1,1);
            //     lCache.Put(2,2);
            //     lCache.Put(3,3);

            //     System.Console.WriteLine(lCache.Get(1));
            //     System.Console.WriteLine(lCache.Get(2));
            //     System.Console.WriteLine(lCache.Get(3));


            //CyclicSort Sort = new CyclicSort();

         //   Sort.calculate();
            //int[] Params = new int[] { 5, 4, 7, 2, 3, 5, 3}; 
            
           // CycleSortWithRepeat sort = new CycleSortWithRepeat();
           // sort.SortData(Params);
            // //
            // var rol = new int[10];
            // rol[0] = 1234;
            //
            // string[] Student = new string[] { "Atik", "Zabir", "Kamal"};
            //
            // Console.WriteLine(Student[0]);
            int[,] multi = new int[2, 3]
            {
                {1, 2, 6},
                {1, 2, 3}

            };

            Console.WriteLine(multi[0, 2]);
        }
    }
}