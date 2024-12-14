/**
 * @param {number[]} nums
 * @return {number}
 */
var maxProductDifference = function(nums) {
 
    let sorted = nums.sort((a, b) => a - b);

    let sum1 = sorted[0] * sorted[1];
    let sum2 = sorted[sorted.length - 1] * sorted[sorted.length - 2];

   
    return sum2 - sum1;
}