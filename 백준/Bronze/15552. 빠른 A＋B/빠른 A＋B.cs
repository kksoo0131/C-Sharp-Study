using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sR = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sW = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sB = new StringBuilder();

        int t = int.Parse(sR.ReadLine());

        while(t-- >0)
        {
            string str = sR.ReadLine();
            string[] strArray = str.Split(" ");
            string nstr = (int.Parse(strArray[0]) + int.Parse(strArray[1])).ToString() + '\n' ;
            sB.Append(nstr);
        }
       

        sW.WriteLine(sB);
        sW.Close();

    }

}