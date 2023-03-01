using System;

public class Solution {
    public string[] solution(string[] quiz) {
        string[] answer = new string[quiz.Length];
        for(int i =0; i < quiz.Length; i++){
            string[] temp = quiz[i].Split();
            int X = int.Parse(temp[0]);
            int Y = int.Parse(temp[2]);
            int Z = int.Parse(temp[4]);
            
            if (temp[1] == "+"){
                if(X + Y == Z)
                    answer[i] = "O";
                else
                    answer[i] = "X";
            }
            else{
                if(X - Y == Z)
                    answer[i] = "O";
                else
                    answer[i] = "X";
                
            }
        }
        return answer;
    }
}