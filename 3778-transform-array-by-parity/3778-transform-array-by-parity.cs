using System;
using System.Collections.Generic;

public class Solution {
    public int[] TransformArray(int[] nums) {
        List<int> list1 = new List<int>();

        
        foreach (int num in nums) {
            if (num % 2 != 0) {
                list1.Add(1); 
            } else {
                list1.Add(0);
            }
        }


        int[] numArray = list1.ToArray();
        Array.Sort(numArray); 

        return numArray;
    }
}
