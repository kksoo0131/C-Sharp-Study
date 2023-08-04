using System;

public class Solution {
    public int solution(int[] array, int n) {
        
  
        return Array.FindAll(array, x => x == n ).Length;
    }
}