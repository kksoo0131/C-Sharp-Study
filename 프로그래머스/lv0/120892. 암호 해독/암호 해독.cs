using System;
using System.Linq;

public class Solution {
    public string solution(string cipher, int code) {
        // string.Where(c,i) 는 x로 char를 i로 index를 가져온다.
        return String.Concat(cipher.Where( (c,i) => i % code == code-1));
    }
}