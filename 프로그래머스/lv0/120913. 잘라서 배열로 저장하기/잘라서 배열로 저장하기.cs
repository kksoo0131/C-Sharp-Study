using System;

public class Solution {
    public string[] solution(string my_str, int n) {
 
        int answerL = (my_str.Length -1 )/ n + 1 ;
        
        string[] answer = new string[answerL];
    
        for(int i = 0; i < answerL; i++){
            answer[i] = (i == answerL -1 ? my_str.Substring(n*i, my_str.Length - n*i) : my_str.Substring(n*i, n));
        }

        return answer;
    }
}