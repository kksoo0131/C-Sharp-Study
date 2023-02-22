using System;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
        Array.Sort(array);
        
        int array_max = array[array.Length-1];
        
        int[] answer_array = new int[array_max+1];
        
        for (int i =0; i <=array_max; i++) 
            answer_array[i] = array.Count(x => x == i);
        
        foreach (int i in answer_array){
            Console.Write($"{i} ");
        }
        
        if (answer_array.Count(x => x == answer_array.Max() ) > 1) return -1;
        
        int answer = Array.IndexOf(answer_array, answer_array.Max());
        
        return answer;
         
    }
}