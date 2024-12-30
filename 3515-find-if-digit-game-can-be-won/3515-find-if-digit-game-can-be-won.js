/**
 * @param {number[]} nums
 * @return {boolean}
 */
var canAliceWin = function(nums) {
    single=[]
    double=[]
    for(letter of nums){
        if(letter>9){
             double.push(letter)
        }else{
          single.push(letter)
        }
    }
    let sum1=single.reduce((accu,curr)=>(accu+curr),0)
    let sum2 = double.reduce((acc,curr)=>acc+curr,0)
 if(sum1 == sum2){
     return false
 }else{
     return true
 }

};