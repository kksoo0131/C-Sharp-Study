using System;

public class Solution {
    public int solution(string my_string) {
        int idx = -1;
        int answer = 0;
        
        for (int i=0; i < my_string.Length; i++){
            if ((int)my_string[i] > 57){
                if (idx != -1){
                    answer += int.Parse(my_string.Substring(idx, i-idx));
                    idx = -1;
                }
                    
            }
            else {
                if (idx == -1)
                    idx = i;
            }
        }
        
        if (idx != -1)
            answer += int.Parse(my_string.Substring(idx, my_string.Length - idx));
        
        return answer;
    }
}