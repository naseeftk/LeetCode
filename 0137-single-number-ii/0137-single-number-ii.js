/**
 * @param {number[]} nums
 * @return {number}
 */
var singleNumber = function(nums) {
    let arr=[]
    for(i=0;i<=nums.length;i++){
        if(nums.indexOf(nums[i])==nums.lastIndexOf(nums[i])){
            return nums[i]
        }
    }
    
};