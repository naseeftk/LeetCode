public class Solution {
    public string Multiply(string num1, string num2) {
      
        BigInteger number1 = BigInteger.Parse(num1);
        BigInteger number2 = BigInteger.Parse(num2);

      
        BigInteger result = number1 * number2;
        return result.ToString();
    }
}