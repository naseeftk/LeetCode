public class Solution {
    public int MinElement(int[] nums) {
        return nums.Select(n=>n.ToString().Select(c=>c-'0').Sum()).Min();
    }
}