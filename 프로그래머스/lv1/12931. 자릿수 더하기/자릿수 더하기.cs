using System;

public class Solution {
    public int solution(int n) {
        string str = n.ToString();
        int answer = 0;
        foreach(char c in str){
            answer += int.Parse(c.ToString());
        }
        
        return answer;
    }
}