public class Solution {
    public int ReverseDegree(string s) {
       var Value= s.Select((x,i)=>(i+1 ) * ('z' - x + 1));
       return Value.Sum();
    }
}