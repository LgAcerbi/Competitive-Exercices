function kangaroo(x1, v1, x2, v2) {
    let k1jps = 0, k2jps = 0;
    let theyCan = false;
    for(let  i = 0; i < 100001; i++){
        if(x1 == x2 && k1jps == k2jps){
            theyCan = true;
            break;
        }
        x1 += v1;
        x2 += v2;
        k1jps++;
        k2jps++;
    }
    if(theyCan == false){
        return "NO"
    }
    else{
        return "YES"
    }
}