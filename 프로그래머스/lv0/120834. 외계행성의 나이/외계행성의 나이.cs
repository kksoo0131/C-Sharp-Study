using System;

public class Solution {
    public string solution(int age) {
        string answer = "";
        string[] list = {"a","b","c","d","e","f","g","h","i","j"};
        string age_string = age.ToString();
        for (int i =0; i < age_string.Length; i++){
            answer += list[int.Parse(age_string[i].ToString())];
        }
        return answer;
    }
}