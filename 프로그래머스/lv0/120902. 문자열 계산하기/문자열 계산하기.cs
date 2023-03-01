using System;

public class Solution {
    public long solution(string my_string) {
        int answer = 0;
        int op = 0;
        string[] array = my_string.Split();
        foreach (string s in array){
            if (s == "+")
                op = 0;
            else if (s == "-"){
                op = 1;
            }
            else{
                if(op == 0 ){
                    answer += int.Parse(s);
                }
                else{
                    answer -= int.Parse(s);
                }
                
            }
        }
        return answer;
    }
}