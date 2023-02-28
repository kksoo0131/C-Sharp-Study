using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        return String.Concat(s.Where( x => s.Count(y => x == y) == 1).OrderBy(x => x));
    }
}