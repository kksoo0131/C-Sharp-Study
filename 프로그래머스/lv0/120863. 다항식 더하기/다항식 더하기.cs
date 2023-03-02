using System;

public class Solution {
    public string solution(string polynomial) {
        string[] array = polynomial.Split();
        long x = 0;
        long c = 0;
        
        foreach(string s in array){
            if (s == "+") 
                continue;
              
            if (s.Contains('x') ){
                if (s == "x") {
                    x += 1; 
                }
                else 
                    x += Convert.ToInt64(s.Substring(0, s.Length-1) );
            }
            else
                c += Convert.ToInt64(s.ToString());     
             
        }
        
        if (x ==0) return $"{c}";
        
        if (x ==1) {
            if (c == 0) return "x";
            else return $"x + {c}";
        }
        
        if (c==0) return $"{x}x";
        
        return $"{x}x + {c}";
    }
}