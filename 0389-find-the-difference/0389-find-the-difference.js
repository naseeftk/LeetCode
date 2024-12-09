/**
 * @param {string} s
 * @param {string} t
 * @return {character}
 */
var findTheDifference = function(s, t) {
     for (let A of s)
        t = t.replace(A, '');
    return t;
};