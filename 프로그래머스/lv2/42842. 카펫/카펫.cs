using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        int total = brown + yellow;
        answer[0] = total/3;
        
        while(true)
        {
            if (total % answer[0] == 0)
            {
                answer[1] = total / answer[0];
                if ((answer[0] - 2) * (answer[1] - 2) == yellow &&
                    (answer[0] + answer[1] -2) *2 == brown)
                    break;
            }
            
            answer[0]--;
                
        }
        
        
        return answer;
    }
}