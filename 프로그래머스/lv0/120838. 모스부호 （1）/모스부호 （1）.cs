using System;

public class Solution {
    public string solution(string letter) {
        string[] morse = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        string[] letter_s = letter.Split(); 
        string answer = "";

        foreach(string s in letter_s){
            for(int i=0; i < morse.Length; i++){
                if(s == morse[i]){
                    answer += (char)(97+i);
                }
            }    
        }
        
            
        return answer;
            
        }
    }
