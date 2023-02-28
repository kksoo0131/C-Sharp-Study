using System;

public class Solution { 
    public long solution(string numbers) {
        string[] number_list = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        
        for (int i=0; i< number_list.Length; i++){
            numbers =numbers.Replace(number_list[i], i.ToString());
        }
        
        return Convert.ToInt64(numbers);
    }
}