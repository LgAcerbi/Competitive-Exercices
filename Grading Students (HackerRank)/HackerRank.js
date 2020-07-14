function gradingStudents(grades) {
    let finalNotes = new Array (grades.length)
    for(let i = 0; i < grades.length; i++){
        if(grades[i] >= 38){
            for(let j = grades[i]; j <= 100; j++){
                if(j % 5 == 0 && j - grades[i] <= 2)
                {
                    finalNotes[i] = j;
                    break;
                }
                else if(j == 3){
                    finalNotes[i] = grades[i]
                    break;
                }
                else if(j % 5 == 0 && j - grades[i] > 2)
                {
                    finalNotes[i] = grades[i]
                    break;
                }
            }
        }
        else{
            finalNotes[i] = grades[i]
        }
    }
    return finalNotes

}