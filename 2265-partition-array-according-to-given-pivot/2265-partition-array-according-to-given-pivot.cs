using System;
using System.Collections.Generic;

public class Solution
{
    public int[] PivotArray(int[] nums, int pivot)
    {
        List<int> left = new List<int>();  
        List<int> middle = new List<int>(); 
        List<int> right = new List<int>(); 

        foreach (int num in nums)
        {
            if (num < pivot)
                left.Add(num);
            else if (num == pivot)
                middle.Add(num);
            else
                right.Add(num);
        }
        left.AddRange(middle);
        left.AddRange(right);

        return left.ToArray();
    }
}
