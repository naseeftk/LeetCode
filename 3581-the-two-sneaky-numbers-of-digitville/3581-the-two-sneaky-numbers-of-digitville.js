/**
 * @param {number[]} nums
 * @return {number[]}
 */
var getSneakyNumbers = function (nums) {
    const numsMap = new Set();

    return nums.reduce((result, num) => {
        if (numsMap.has(num)) {
            result.push(num);
        } else {
            numsMap.add(num)
        }

        return result;
    }, [])
};