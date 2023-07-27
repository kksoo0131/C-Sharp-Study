using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string str = n.ToString();
        
        foreach (char c in str){
            answer += int.Parse(c.ToString());
        }

        return answer;
    }
}