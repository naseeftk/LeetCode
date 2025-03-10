using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        List<bool> Kids = new List<bool>(); 
        
        int maxCandy = candies.Max(); 

        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= maxCandy)
            {
                Kids.Add(true); // ✅ Add semicolon
            }
            else
            {
                Kids.Add(false);
            }
        }

        return Kids; 
    }
}
