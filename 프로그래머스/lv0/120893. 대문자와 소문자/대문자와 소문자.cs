using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        foreach (char c in my_string){
            answer += c < 97 ? Char.ToLower(c) : Char.ToUpper(c);
        }
        return answer;
    }
}