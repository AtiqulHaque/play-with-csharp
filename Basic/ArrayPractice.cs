using System;

namespace problem_solving.Basic {
    public class ArrayPractice {

        public ArrayPractice () {

            //single dimention

            // int[] numbers = new int[10];
            // int index = 0;

            // while (index < 10) {
            //     System.Console.WriteLine("Enter you value: ");
            //     string value = Console.ReadLine ();
            //     numbers[index] = Convert.ToInt32 (value);
            //     index++;
            // }

            // foreach (int indexVal in numbers) {
            //     System.Console.WriteLine (indexVal);
            // }

            int[, ] matrix = new int[,] {
                 { 1, 2, 3 }, 
                 { 5, 6, 7} 
                
            };

        
            for (int i = 0; i < matrix.GetLength (0); i++) {
                for (int j = 0; j < matrix.GetLength (1); j++) {
                    System.Console.WriteLine (
                        "matrix val {0} topleft value {6}  top value {1} top right {5} right value {2} bottomRight value {8} bottom value {4} bottomLeft value {7} left value {3}", matrix[i, j], 
                    this.GetTopVal(matrix, i, j), 
                    this.GetRightVal(matrix, i, j),
                    this.GetLeftVal(matrix, i, j),
                    this.GetBottomVal(matrix, i, j),
                    this.GetTopRightVal(matrix, i, j),
                    this.GetTopLeftVal(matrix, i, j),
                    this.GetBottomRightVal(matrix, i, j),
                    this.GetBottomLeftVal(matrix, i, j)
                    );

                }
            }

        }

        
        
        public int GetTopVal( int[, ] matrix, int dimentionX, int dimentionY){
            if(dimentionX > 0){
                return matrix[dimentionX - 1, dimentionY];
            }
            else{
                return 0;
            }

        }
         public int GetTopRightVal( int[, ] matrix, int dimentionX, int dimentionY){
            if(dimentionX > 0 && dimentionY < matrix.GetLength(1) - 1){
                return matrix[dimentionX - 1, dimentionY + 1];
            }
            else{
                return 0;
            }

        }
         public int GetTopLeftVal( int[, ] matrix, int dimentionX, int dimentionY){
            if(dimentionX > 0 && dimentionY > 0){
                return matrix[dimentionX - 1, dimentionY - 1];
            }
            else{
                return 0;
            }

        }
        
        public int GetBottomVal( int[, ] matrix, int dimentionX, int dimentionY){
            if(dimentionX < matrix.GetLength(0) - 1){
                return matrix[dimentionX + 1, dimentionY];
            }
            else{
                return 0;
            }

        }

        public int GetBottomLeftVal( int[, ] matrix, int dimentionX, int dimentionY){
            if(dimentionX < matrix.GetLength(0) - 1 && dimentionY < matrix.GetLength(1) - 1){
                return matrix[dimentionX + 1, dimentionY + 1];
            }
            else{
                return 0;
            }

        } 
        
        public int GetBottomRightVal( int[, ] matrix, int dimentionX, int dimentionY){
            if(dimentionX < matrix.GetLength(0) - 1 && dimentionY > 0){
                return matrix[dimentionX + 1, dimentionY - 1];
            }
            else{
                return 0;
            }

        }

        public int GetRightVal( int[, ] matrix, int dimentionX, int dimentionY){
            if(dimentionY < matrix.GetLength(1) - 1){
                return matrix[dimentionX, dimentionY + 1];
            }
            else{
                return 0;
            }

        }

        public int GetLeftVal( int[, ] matrix, int dimentionX, int dimentionY){
            if(dimentionY > 0){
                return matrix[dimentionX, dimentionY - 1];
            }
            else{
                return 0;
            }

        }
    }
}