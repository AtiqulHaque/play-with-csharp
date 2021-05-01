using System;

namespace problem_solving {
    public class Matrix {
        public void Rotate (int angle) {
            int[, ] array2D = new int[, ] { { 1,2,3 }, { 4,5,6 }, { 7,8,9 }};
            int n = array2D.GetLength (0), m = array2D.GetLength (1);

           
            for (int i = 0; i < n; i++) {
                for (int j = i; j < n; j++) {
                    System.Console.WriteLine("{0}, {1}", i,j);
                    int temp = array2D[i, j];
                    array2D[i, j] = array2D[j,i];
                    array2D[j, i] = temp; 
                }

            }

            // for (int i = 0; i < n; i++) {
            //     for (int j = 0; j < Math.Ceiling (Convert.ToDouble (array2D.GetLength (0) / 2)); j++) {
            //         int temp = array2D[i, j];
            //         array2D[i, j] = array2D[i, m - j];
            //         array2D[i, m - j] = temp;
            //     }
            // }

            showData (array2D);

        }

        public void swap (int current, int next, int value) {

        }

        public void showData (int[, ] array2D) {

            for (int i = 0; i < array2D.GetLength (0); i++) {
                for (int j = 0; j < array2D.GetLength (1); j++) {
                    System.Console.Write ("{0} ", array2D[i, j]);
                }
                System.Console.WriteLine ("");
            }
        }

    }
}