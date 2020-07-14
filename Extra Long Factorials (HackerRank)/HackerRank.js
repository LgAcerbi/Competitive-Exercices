function extraLongFactorials(n) {
    let resul = n;
    resul = BigInt(resul)
    let temp = 0;
    for(let i = n -1; i >= 1; i--){
        temp = i;
        temp = BigInt(temp)
        resul *= temp
    }
    console.log(resul.toString())
}