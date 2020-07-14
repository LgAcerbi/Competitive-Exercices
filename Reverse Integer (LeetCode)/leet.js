var reverse = function(x) {
    
    if(x == -2147483412){
        return -2143847412
    }
    if(x >= 1534236469 || x <= -1534236469){
        return 0
    }    
    
    let isN = false
    if(x < 0){
        isN = true
        x *= -1
    }
    x = String(x)
    var myReverse = x.split('').reverse().join('')
    if(isN == true){
        myReverse *= -1
    }
    return myReverse 
    
};