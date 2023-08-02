using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        
        foreach(char c in my_string){
            for(int i = 0; i< n; i++){
                answer += c;        
            }
        }
        return answer;
    }
}