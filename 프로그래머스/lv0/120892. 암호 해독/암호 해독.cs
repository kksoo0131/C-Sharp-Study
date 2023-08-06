using System;

public class Solution {
    public string solution(string cipher, int code) 
    {
        string answer = "";
        
        for(int i =code-1 ; i <cipher.Length; i+=code)
        {
            answer += cipher[i];
        }
        
        return answer;
    }
}