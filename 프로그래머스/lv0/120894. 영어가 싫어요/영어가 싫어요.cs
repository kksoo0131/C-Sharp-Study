using System;

public class Solution { 
    public long solution(string numbers) {
        string answer = "";
        for (int i =0; i < numbers.Length;){
            switch (numbers[i]){
                case 'z':
                    i +=4;
                    answer += "0";
                    break;
                case 'o':
                    i+=3;
                    answer += "1";
                    break;
                case 't':
                    if (numbers[i+1]== 'w'){
                        i +=3;
                        answer += "2";
                    }
                    else{
                        i+=5;
                        answer += "3";
                    }
                    break;
                case 'f':
                    if(numbers[i+1]== 'o'){
                        i+=4;
                        answer += "4";
                    }
                    else{
                        i+=4;
                        answer += "5";
                    }
                    break;
                case 's':
                    if(numbers[i+1]== 'i'){
                        i+=3;
                        answer += "6";
                    }
                    else{
                        i+=5;
                        answer += "7";
                    }
                    break;
                case 'e':
                    i+=5;
                    answer += "8";
                    break;
                case 'n':
                    i+=4;
                    answer += "9";
                    break;
                        
            }
        }
        
        return Convert.ToInt64(answer);
    }
}