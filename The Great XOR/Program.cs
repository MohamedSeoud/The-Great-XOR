using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    static string ConvertToBinary(long number)
    {
        string ret = "";
        while (number > 0)
        {
            ret = (number % 2 == 0 ? "0" : "1") + ret;
            number /= 2;
        }
        return ret;
    }

    // Complete the theGreatXor function below.
    static long theGreatXor(long x)
    {
        long ret = 0;
        string c = ConvertToBinary(x);
        int len = c.Length;
        int counter = 0;

        for (int i = len - 1; i > -1; i--)
        {

            if (c[i].ToString() == "0")
            {
                ret += (long)Math.Pow(2, counter);
            }
            counter++;
        }
        return ret;
    }

    static void Main(string[] args)
    {
   //     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long x = Convert.ToInt64(Console.ReadLine());

            long result = theGreatXor(x);

//            textWriter.WriteLine(result);
        }

  //      textWriter.Flush();
   //     textWriter.Close();
    }
}
