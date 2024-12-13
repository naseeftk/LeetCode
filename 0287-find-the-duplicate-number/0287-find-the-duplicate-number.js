/**
 * @param {number[]} nums
 * @return {number}
 */
// var findDuplicate = function(nums) {     
//     let newarr = nums.filter((x) => nums.indexOf(x) !== nums.lastIndexOf(x));
    
//     for (let value of nums) {
//         if (newarr.includes(value)) {
//             return value; 
//         }
//     }
// };


var findDuplicate = function(nums) {
    let seen = new Set();
    for (let value of nums) {
        if (seen.has(value)) {
            return value; 
        }
        seen.add(value);
    }
    return -1; 
};

