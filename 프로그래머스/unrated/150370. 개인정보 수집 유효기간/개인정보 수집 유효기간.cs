using System;
using System.Collections.Generic;

public class Solution
{
    static string Expired(string array1, string array2)
    {    
        int year = int.Parse(array1.Substring(0, 4));
        int month = int.Parse(array1.Substring(5, 2));
        string date = array1.Substring(8, 2);

        if (array1.Contains(array2.Substring(0, 1)))
        {
            if (array2.Length == 3)
                month = month + int.Parse(array2.Substring(2, 1));
            else if (array2. Length ==5)
                month = month + int.Parse(array2.Substring(2, 3));
            else
                month = month + int.Parse(array2.Substring(2, 2));

            while (month > 12)
            {
                year += 1;
                month -= 12;
            }
           
            if (month < 10)
                array1 = $"{year}.0{month}.{date}";
            else
                array1 = $"{year}.{month}.{date}";

            return array1;
        }
        return array1;
             
    }

    static bool MyCompare(string array, string today)
    {
        DateTime today_date = new DateTime
            (int.Parse(today.Substring(0, 4)), int.Parse(today.Substring(5, 2)), int.Parse(today.Substring(8, 2)));

        DateTime array_date = new DateTime
            (int.Parse(array.Substring(0, 4)), int.Parse(array.Substring(5, 2)), int.Parse(array.Substring(8, 2)));
        if (DateTime.Compare(today_date, array_date) >= 0)
            return true;
        else
            return false;


    }
    
    public List<int> solution(string today, string[] terms, string[] privacies)
    {
        List<int> answer = new List<int>();
        List<int[]> list = new List<int[]>();

        for (int i = 0; i < privacies.Length; i++)
        {
            for (int j = 0; j < terms.Length; j++)
            {
                privacies[i] = Expired(privacies[i], terms[j]);
            }
            if (MyCompare(privacies[i], today))
                answer.Add(i + 1);
        }
        return answer;        
    }
        
    
}

