using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        int total = brown + yellow;
        int max_width = total/3;
        
        for(int i=3 ; i <=max_width; i++){
            for(int j =3; j<=i; j++){
                if (brown == (i + j -2)*2 && yellow == (i-2)*(j-2)){
                    return new int[]{i,j};
                }
                    
            }
        }
        return answer;
    }
}