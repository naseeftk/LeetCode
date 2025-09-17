public class Solution {
    public int[] GetConcatenation(int[] nums) {
        List<int> list = new List<int>();
        
        for (int i = 0; i < nums.Length; i++) {
            list.Add(nums[i]);
        }
        for (int i = 0; i < nums.Length; i++) {
            list.Add(nums[i]);
        }

        return list.ToArray();
    }
}
