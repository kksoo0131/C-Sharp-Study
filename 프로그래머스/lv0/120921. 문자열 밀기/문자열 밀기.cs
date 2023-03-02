using System;

public class Solution {
    public int solution(string A, string B) {
        int answer = 0;
        if (A == B)
            return answer;
        
        for(int i =0; i < A.Length; i++){
            answer +=1;
            A = Push(A.ToCharArray());
            if (A == B)
                return answer;
        }
        
        return -1;
    }
    
    static string Push(char[] c){
        string answer = "";
        char temp = c[c.Length-1];
        for (int i =c.Length-1; i >0; i--){
            c[i] = c[i-1];
        }
        c[0] = temp;
        return new string(c);
    }
}