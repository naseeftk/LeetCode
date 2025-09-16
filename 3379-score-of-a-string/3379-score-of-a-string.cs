public class Solution {
    public int ScoreOfString(string s) {
        int num = 0;
        for (int i = 0; i < s.Length - 1; i++) {
            num += Math.Abs(s[i] - s[i + 1]); // ASCII difference
        }
        return num;
    }
}
