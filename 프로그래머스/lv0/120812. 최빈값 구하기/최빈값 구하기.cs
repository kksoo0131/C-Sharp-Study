using System;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
    
        int[] check = new int[array.Max()+1];
        
        for (int i =0; i < check.Length; i++) check[i] = array.Count(x => x == i);   
        
        if (check.Count(x => x == check.Max() ) > 1) return -1;
                
        return Array.IndexOf(check, check.Max());
         
    }
}
