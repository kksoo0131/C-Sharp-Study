using System;
using System.Linq;


public class Solution {
    public int[] solution(string[] strlist) {
        
        return strlist.Select(x => x.Length).ToArray();
    }
}