namespace problem_solving {
    public class ZerosMovie {
        public void MoveZeroes (int[] nums) {
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == 0) {
                    if ((i + 1) < nums.Length) {
                        if (nums[i + 1] == 0) {
                            continue;
                        } else {
                            int temp = nums[i + 1];
                            nums[i + 1] = nums[i];
                            if (i == 0) {
                                nums[i] = temp;
                            } else {
                                int tempIndex = i;
                                int lastIndex = -1;
                                while (tempIndex >= 0) {
                                    if (nums[tempIndex] == 0) {
                                        lastIndex = tempIndex;
                                    }

                                    tempIndex--;
                                }

                                if (lastIndex != -1) {
                                    nums[lastIndex] = temp;
                                }
                            }

                        }
                    }
                }
            }

            for (int i = 0; i < nums.Length; i++) {
                System.Console.WriteLine (nums[i]);
            }
        }
    }
}