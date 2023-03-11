using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[] {0,0};
        while( s != "1"){
            int preLength = s.Length;
            s = s.Replace("0", "");
            answer[0] += 1;
            answer[1] += preLength - s.Length;
            s = Convert.ToString(s.Length, 2);    
        }
        
        
        
        
        return answer;
    }
}