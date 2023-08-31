using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(string today, string[] terms, string[] privacies) 
    {
        DateTime todayDate = DateTime.Parse(today);
        Dictionary<string,int> termsDic = new Dictionary<string,int>();
        List<int> answer = new List<int>();
        
        foreach(string term in terms)
        {
            termsDic.Add(term.Substring(0,1),int.Parse(term.Substring(2,term.Length-2)));
        }
        
        for(int i=0; i< privacies.Length; i++)
        {
            DateTime date = DateTime.Parse(privacies[i].Substring(0,10));
            string type = privacies[i].Substring(11,1);
            
            int result = DateTime.Compare(todayDate, date.AddMonths(termsDic[type]));
            Console.WriteLine($"{todayDate} {date.AddMonths(termsDic[type])} {type}");
            if(result >= 0 )
            {
                answer.Add(i+1);
            }
        }
        return answer.ToArray();
    }
}