using System.Text;
public class Solution
{
    public string solution(string phone_number)
    {
        StringBuilder str = new StringBuilder(phone_number);
        for (int i = 0; i < str.Length - 4; i++)
        {
            str[i] = '*';
        }
        return str.ToString();
    }
}