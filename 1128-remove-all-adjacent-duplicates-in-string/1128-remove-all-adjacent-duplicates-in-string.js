/**
 * @param {string} s
 * @return {string}
 */
var removeDuplicates = function(s) {
    let text = [];
    
    for (let i = 0; i < s.length; i++) {
        if (s[i] === text[text.length - 1]) {
           text.pop();
        } else {
            text.push(s[i]);
        }
    }
    
    return text.join('');
};