namespace problem_solving {
    public class Factorial {
        public int Calculate (int kth) {

            if (kth == 0) {
                return 1;
            }

            return kth * Calculate (kth - 1);
        }
    }
}