using System;
public class Solution {
    public string solution(string s) {
        string answer = "";
        int length = s.Length;
        return length % 2 ==0 ? s.Substring(length/2-1,2) : s.Substring(length/2,1);
    }
}