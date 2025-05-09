public class Solution {
    public int SingleNumber(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            bool isUnique = true;
            for (int j = 0; j < nums.Length; j++) {
                if (i != j && nums[i] == nums[j]) {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique) {
                return nums[i];
            }
        }
        return -1; // fallback in case no unique number is found
    }
}
