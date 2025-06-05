public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int result=0;
        for(int i=0;i<accounts.Length;i++){
            if(result<accounts[i].Sum())
           {
 result=accounts[i].Sum();
            }
        }
        return result;
    }
}