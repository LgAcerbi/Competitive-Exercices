function timeConversion(s) {
    let AM = false
    if(s[s.length - 2] == 'A'){
        AM = true
    }
    s = s.slice(0,-2)
    s = s.split(':')
    
    if(AM == true){
        if(s[0] == '12'){
            s[0] = '00'
        }
    }
    else{
        s[0] = parseInt(s[0]) + 12
        if(s[0] == '24'){
            s[0] = '12'
        }
    }
    s = s.join(':')
    return s
}