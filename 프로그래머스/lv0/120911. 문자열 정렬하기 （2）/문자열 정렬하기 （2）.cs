using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        return String.Concat(my_string.ToLower().OrderBy(x => x));
    }
}