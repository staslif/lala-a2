using System;
using System.Diagnostics;

const int multipleOfThisNumber = 14, maxArrayLength = 1000, maxValueInArray = 10000;
 static void Main(string[] args)
{
    int[] array = new int[maxArrayLength]; 
    Random r = new();
    for (int i = 0; i < array.Length; i++)
        array[i] = r.Next(0, maxValueInArray);

    int majorityElement = FindMajorityElement(array);

    if (majorityElement != -1 && majorityElement % multipleOfThisNumber == 0)
    {
        Console.WriteLine($"{majorityElement} - это число соответствует условиям задачи.");
    }
    else
    {
        Console.WriteLine(-1);
    }
}
 static int FindMajorityElement(int[] array)
{
    int candidate = 0;
    int count = 0;
    foreach (int num in array)
    {
        if (count == 0)
        {
            candidate = num;
        }
        count += (num == candidate) ? 1 : -1;
    }
    count = 0;
    foreach (int num in array)
    {
        if (num == candidate)
        {
            count++;
        }
    }
    return (count > array.Length / 2) ? candidate : -1;
}
