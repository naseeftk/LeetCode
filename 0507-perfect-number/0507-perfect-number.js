/**
 * @param {number} num
 * @return {boolean}
 */
var checkPerfectNumber = function(num) {
    let sum = 1
    if(num === 1) return false
    for(i=2; i<num; i++){
        if(num % i === 0) sum += i;
    }
    return sum === num
};