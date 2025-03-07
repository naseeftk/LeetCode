using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] NumberGame(int[] nums)
    {
        // Convert to a List<int> for easy manipulation
        List<int> numbers = nums.ToList();
        List<int> result = new List<int>();

        
        numbers.Sort();

        while (numbers.Count > 1)
        {
           
            int alicePick = numbers[0];
            numbers.RemoveAt(0);

            int bobPick = numbers[0];
            numbers.RemoveAt(0);

            result.Add(bobPick);
            result.Add(alicePick);
        }

        return result.ToArray(); 
    }
}
