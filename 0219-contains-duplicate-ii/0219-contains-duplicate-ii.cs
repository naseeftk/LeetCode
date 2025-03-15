public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) 
{
        HashSet<int> numIndices = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (numIndices.Contains(nums[i])) 
            {
                return true;
            }

            numIndices.Add(nums[i]);

            if (numIndices.Count > k) 
            {
                numIndices.Remove(nums[i - k]);
            }
        }

        return false;
    }
}