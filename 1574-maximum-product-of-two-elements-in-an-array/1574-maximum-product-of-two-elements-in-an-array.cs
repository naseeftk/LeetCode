public class Solution {
    public int MaxProduct(int[] nums) {
             Array.Sort(nums);
        Array.Reverse(nums);
        int a=nums[0]-1;
        int b=nums[1]-1;
        return a*b;

        
    }
}