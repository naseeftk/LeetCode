function countDigits(num) {
    let count = 0;
    const numStr = num.toString(); 

    for (const char of numStr) { 
        const digit = parseInt(char)

       
        if (digit !== 0 && num % digit === 0) {
            count++;
        }
    }

    return count;
}

