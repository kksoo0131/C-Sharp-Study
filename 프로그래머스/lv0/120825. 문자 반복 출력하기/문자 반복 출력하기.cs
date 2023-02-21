using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        foreach (char c in my_string){            
                answer += new string(c,n); 
        }
        return answer;
    }
}