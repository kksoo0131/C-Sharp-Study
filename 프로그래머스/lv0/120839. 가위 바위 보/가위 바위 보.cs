using System;

public class Solution {
    public string solution(string rsp) {
        string answer = "";
        
        foreach(char c in rsp){
            
            answer += c == '0' ?  5 : c == '2' ? 0 : 2;
        }
        return answer;
    }
}