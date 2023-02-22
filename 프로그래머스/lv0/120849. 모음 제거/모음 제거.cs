using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        string[] vowel = {"a", "e", "i", "o", "u"};
        
        foreach (string s in vowel){
            my_string = my_string.Replace(s , "");
        }
        
        
        return my_string;
    }
}