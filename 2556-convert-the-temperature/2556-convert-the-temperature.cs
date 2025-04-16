public class Solution {
    public double[] ConvertTemperature(double celsius) {
        double k1=celsius+273.15;
        double f1=celsius*1.80+32.00;
      
        double[] arr= new double[2];
        arr[0]=Convert.ToDouble(k1);
        arr[1]=Convert.ToDouble(f1);
        return arr;
    }
}