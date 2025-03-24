public class Solution {
    public bool UniqueOccurrences(int[] arr) {
return arr.GroupBy(x => x).Select(x => x.Count()).Distinct().Sum() == arr.Length;
    }
}