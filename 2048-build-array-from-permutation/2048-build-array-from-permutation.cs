public class Solution {
    public int[] BuildArray(int[] nums) {

      List<int> list= new List<int>();
       for(int i=0;i < nums.Length;i++){
     list.Add(nums[nums[i]]);

       }
       return list.ToArray();
    }
}