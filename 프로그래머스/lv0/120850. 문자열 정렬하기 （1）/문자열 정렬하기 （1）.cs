using System;
using System.Linq;

public class Solution {
    public int[] solution(string my_string) {
        return String.Concat(my_string.Where(x => (x >=48 && x <=57))).Select(x => int.Parse(x.ToString())).OrderBy(x => x).ToArray();
    }
}