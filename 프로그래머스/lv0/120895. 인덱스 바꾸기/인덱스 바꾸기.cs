using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        string answer = "";
        for (int i =0; i < my_string.Length; i++){
            answer += (i == num1 ?my_string[num2].ToString() : 
                       i ==num2 ? my_string[num1].ToString() : 
                       my_string[i].ToString());
            
        }
        return answer;
    }
}