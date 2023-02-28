using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string list = "abcdefghijklmnopqrstuvwxyz";
        for (int i=0; i < list.Length; i++){
            if (s.Count(x => x == list[i]) == 1)
                answer += list[i];
        }
        
        return answer;
    }
}