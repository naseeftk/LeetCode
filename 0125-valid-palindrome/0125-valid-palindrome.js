/**
 * @param {string} s
 * @return {boolean}
 */
// var isPalindrome = function(s) {
//    str= s.toLowerCase().replaceAll(" ","").replace(":","").split('')
//   return str==str.reverse()
    
// };
var isPalindrome = function(s) {
    let str = s.replace(/[^a-z0-9]/gi, '').toLowerCase();
    let rev = str.split("").reverse().join("");
    return (str == rev) ? true : false;
};