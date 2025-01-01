/**
 * @param {string} num
 * @return {boolean}
 */
var isBalanced = function(num) {
    let arr1=[]
    let arr2=[]
        for(i=0;i<num.length;i++){
        if((i+1)%2===0){
            arr2.push(Number(num[i]))
        }else{
             arr1.push(Number(num[i]))
        }
    }
    console.log(arr2)
    sum1=arr1.reduce((accu,curr)=>accu+curr,0)
    sum2=arr2.reduce((accu,curr)=>accu+curr,0)
    return sum1===sum2
};