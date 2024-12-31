/**
 * @param {number[][]} matrix
 * @param {number} k
 * @return {number}
 */
var kthSmallest = function(matrix, k) {
   arr= matrix.flat()
sorted=arr.sort((a,b)=>a-b)
return(sorted[k-1])
   
};