/**
 * @param {string[]} strs
 * @return {string[][]}
 */
var groupAnagrams = function(strs) {
    let obj = {}; 

    for (let word of strs) {

        let sorted = word.split("").sort().join("");

        if (!obj[sorted]) {
            obj[sorted] = [];
        }
        obj[sorted].push(word);
    }

 
    return Object.values(obj);
};
