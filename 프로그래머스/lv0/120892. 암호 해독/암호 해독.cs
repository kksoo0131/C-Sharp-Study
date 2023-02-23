using System;
using System.Linq;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = "";
        
        for (int i = code-1; i < cipher.Length; i++){
            
            if ((i % code == code-1) )
                answer += cipher[i].ToString();
        }
        return answer;
    }
}