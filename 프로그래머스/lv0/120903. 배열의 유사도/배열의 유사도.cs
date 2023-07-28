using System;
using System.Linq;

public class Solution {
    public int solution(string[] s1, string[] s2) {
        int answer = 0;
        
        foreach(string str in s1){
            answer += s2.Contains(str) ? 1 : 0;
        }
        return answer;
    }
}