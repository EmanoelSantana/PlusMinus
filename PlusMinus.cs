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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int positive = 0;
        int zero = 0;
        int negative = 0;

        for (int c = 0; c < arr.Count; c++) 
        {
            if (arr[c] > 0)
            {
                positive++;
            } 
            else if (arr[c] < 0)
            {
                negative++;
            }
            else if (arr[c] == 0)
            {
                zero++;
            }
        }

        Console.WriteLine((float)positive / arr.Count);
        Console.WriteLine((float)negative / arr.Count);
        Console.WriteLine((float)zero / arr.Count);
        
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
