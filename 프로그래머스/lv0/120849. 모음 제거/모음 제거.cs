using System;

public class Solution {
    public string solution(string my_string) {
        string vowel = "aeiou";
        
        foreach (char c in vowel){
            my_string = my_string.Replace(c.ToString(), "");
        }
        
        
        return my_string;
    }
}