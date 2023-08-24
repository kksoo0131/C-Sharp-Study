using System;
using System.Text;

public class Example
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder();

        Console.Clear();
        string[] s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);
        
        for(int i =0; i< b; i++){
            for(int j =0; j< a; j++){
                sb.Append("*");
            }
            sb.Append("\n");
        }
        
        Console.WriteLine(sb.ToString());
    }
}