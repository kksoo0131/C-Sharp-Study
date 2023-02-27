using System;

public class Solution {
    public int solution(string s) {
        string[] ss = s.Split();
        int answertemp = 0;
        int answer = 0;
        
        foreach (string x in ss){
            
            if (x == "Z"){
                answer = answertemp;
                continue;
            }
            answertemp = answer;
            answer += int.Parse(x);
            
            
        }
        return answer;
    }
}