var myAtoi = function(str) {
    
    let digits = ['0','1','2','3','4','5','6','7','8','9']
    let i = 0;
    while(str[i] == " ")
    {
        i++;
    }
    if(str[i] == '-'){
        if(getNumbers(i+1,str, digits)*-1 <= Math.pow(-2,31))
            return Math.pow(-2,31)
        else
            return '-' + getNumbers(i+1,str, digits)
    }
    else if(digits.includes(str[i])){
        if(getNumbers(i,str, digits) >= Math.pow(2,31))
            return Math.pow(2,31) - 1
        else
            return getNumbers(i, str, digits)
    }
    else if(str[i] == '+'){
        if(getNumbers(i+1,str, digits) >= Math.pow(2,31))
            return Math.pow(2,31) - 1
        else
            return getNumbers(i+1, str, digits)
    }
    else{
        return 0
    }
};

function getNumbers(i, str, digits){
    let Num = '';
    let AchouNum = digits.includes(str[i])
    while(digits.includes(str[i])){
        
        Num += str[i] 
        i++;
    }  
    if(AchouNum == true)
        return Num;
    else
        return 0
}