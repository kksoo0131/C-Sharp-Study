using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        int[] num = Array.ConvertAll(s.Split(" "), int.Parse);        
        return $"{num.Min()} {num.Max()}";
    }
}