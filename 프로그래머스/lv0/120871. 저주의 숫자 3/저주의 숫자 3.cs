using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;

        while (n > 0){
            answer +=1;
            n -=1;
            if(answer % 3 ==0 || answer%10 ==3 || answer / 10 ==3 || answer / 10 == 13)
                n +=1;     
        }
        return answer;
    }
}