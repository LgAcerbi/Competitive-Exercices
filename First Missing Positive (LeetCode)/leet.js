var firstMissingPositive = function(nums) {
    let posArray = []
    let k = 0;
    for(let i = 0; i < nums.length; i++){
        if(nums[i] > 0){
            posArray[k] = nums[i]
            k++
        }
    }
    posArray.sort()
    for(let i = 1; i <= posArray.length + 1; i++){
        if(!(posArray.includes(i))){
            return i;
        }
    }
};