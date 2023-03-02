using System;

public class Solution {
    public int solution(string[] spell, string[] dic) {
        int answer = 2;
        Array.Sort(spell);
        foreach (string s in dic){
            if (spell.Length != s.Length)
                continue;
                
            char[] temp = s.ToCharArray();
            Array.Sort(temp);
            
             for (int i=0; i < temp.Length; i++){
                 if (spell[i] != temp[i].ToString())
                     break;
                 
                 if (i == temp.Length-1)
                     answer = 1;
             }
        }
        return answer;
    }
}