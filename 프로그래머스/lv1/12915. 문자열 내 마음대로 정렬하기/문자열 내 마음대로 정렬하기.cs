using System.Collections.Generic;
using System.Collections.Generic;
using System;
using System.Linq;
public class Solution
    {
        public string[] solution(string[] strings, int n)
        {
            // 문자열 배열을
            // 각 문자열의 인덱스 n글자를 기준으로 정렬한다.

            List<string> list = strings.ToList();
            list.Sort((x, y) =>MyCompare(x,y,n));
            
            return list.ToArray();
        }
    
        public int MyCompare(string a, string b, int n)
        {
            int minLength = Math.Min(a.Length, b.Length);
            int index = 0;
            
            if (a[n] == b[n])
            {
                while(a[index] == b[index] && index < minLength-1)
                {
                index++;
                // 만약 입력받은 a[n]과 b[n]이 같을경우
                // a와 b중 사전순으로 뭐가 우선인지 확인해야된다.
                
                }
            return a[index].CompareTo(b[index]);    
            }
            else{
                return a[n].CompareTo(b[n]);
            }
            
            
        }
    }