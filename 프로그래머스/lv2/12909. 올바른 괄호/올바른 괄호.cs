using System;

public class Solution {
    public bool solution(string s) {
        int check = 0;
        
        foreach (char c in s){
            
            if (check == 0  && c == ')')
                return false;
            
            if (c == '(')
                check +=1;
            else
                check -=1;
        }
        
        if (check == 0)
            return true;
        return false;
    }
}