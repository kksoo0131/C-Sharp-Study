using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        for (int i=0; i< babbling.Length; i++){
            char[] temp = babbling[i].ToCharArray();
            int index = 0;
            while(true)
           {
            if (temp.Length == index){
                answer+=1;
                break;
            }
                
            if (temp.Length - index < 2)
                break;
                
            if (temp[index] == 'y' && temp[index+1] == 'e'){
                index +=2;
                continue;
            }
            if (temp[index] == 'm' && temp[index+1] == 'a'){
                index +=2;
                continue;
            }
            if (temp.Length - index < 3)
                break;
            if (temp[index] == 'a' && temp[index+1] == 'y' && temp[index+2] == 'a'){
                index += 3;
                continue;
            }
               
            if (temp[index] == 'w' && temp[index+1] == 'o' && temp[index+2] == 'o'){
                index += 3;
                continue;
            }
               
            break;    
            }
        }
        return answer;
    }
}