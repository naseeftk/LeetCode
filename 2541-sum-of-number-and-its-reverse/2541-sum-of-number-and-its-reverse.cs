public class Solution {
    public bool SumOfNumberAndReverse(int num) {
        for (int x = 0; x <= num; x++) {
            int y = int.Parse(new string(x.ToString().Reverse().ToArray())); 
            if (x + y == num) {
                return true; 
            }
        }
        return false; 
    }
}
