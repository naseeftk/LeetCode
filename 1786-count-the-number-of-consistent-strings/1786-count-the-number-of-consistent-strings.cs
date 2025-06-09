using System;
using System.Collections.Generic;

public class Solution
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        // Convert allowed characters into a HashSet for O(1) lookup
        var allowedSet = new HashSet<char>(allowed);
        int count = 0;

        foreach (var word in words)
        {
            bool isValid = true;
            foreach (char c in word)
            {
                if (!allowedSet.Contains(c))
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
                count++;
        }

        return count;
    }
}
