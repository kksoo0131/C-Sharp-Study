using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        
        foreach(char c in my_string){
            int num;
            if (int.TryParse(c.ToString(), out num)){
                answer += num;
            }
        }
        return answer;
    }
}