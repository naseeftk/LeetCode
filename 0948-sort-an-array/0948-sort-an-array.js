/**
 * @param {number[]} nums
 * @return {number[]}
 */
var sortArray = function(nums) {
    return nums.sort((a,b)=>a-b)
    
    // for (let i = 0; i < nums.length; i++) {
    //     for (let j = 0; j < nums.length - i - 1; j++) {
    //         if (nums[j] > nums[j + 1]) {
               
    //             let temp = nums[j];
    //             nums[j] = nums[j + 1];
    //             nums[j + 1] = temp;
    //         }
    //     }
    // }
    // return nums;
};
