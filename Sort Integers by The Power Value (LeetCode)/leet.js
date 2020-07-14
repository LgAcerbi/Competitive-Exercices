var getKth = function(lo, hi, k) {
    let array = new Array((hi - lo) + 1)
    for (let i = lo, p = 0; i <= hi; i++, p++)
        {
            array[p] = new Array(2)
            array[p][0] = i;
            array[p][1] = CalcPower(i)                       
        }
    
    array.sort(function(a,b){
        return a[0]-b[0]
    })
    array.sort(function(a,b){
        return a[1]-b[1]
    })
    
    return array[k - 1][0]
    
    function CalcPower(num){
        let power = 0
        while(num != 1){
            if(num % 2 == 0){
                num = num / 2
            }
            else{
                num = 3 * num + 1
            }
            power++
        }
        return power
    }
};
