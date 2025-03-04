public class Solution {
    public int BalancedStringSplit(string s) {
        int r = 0;
        int l = 0;
        int count = 0;
        for(int i = 0; i<s.Length;i++){
            if(s[i]=='R'){
                r++;
            }
            else{
                l++;
            }
            if(r==l){
                count++;
                r=0;l=0;
            }
        }
        return count;
    }
}