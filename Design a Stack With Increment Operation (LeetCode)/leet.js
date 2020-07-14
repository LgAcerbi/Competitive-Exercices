class CustomStack {
    constructor(maxSize){
        this.maxSize1 =  maxSize;
        this.count = 0;
        this.myStack = [];
    };
    push(x) {
        if(this.count < this.maxSize1)
        {
            this.count++
            this.myStack.push(x)
        }
    };
    pop() {
        if(this.myStack.length == 0){
            return -1
        }
        else{
            this.count--
            return this.myStack.pop()
        }
    };
    increment(k, val) {
        for (let i = 0; i < k; i++){
            if(i == this.myStack.length){
                break;
            }
            this.myStack[i] += val
        }
    }
}