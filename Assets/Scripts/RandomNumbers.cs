using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumbers : MonoBehaviour
{
    public static int CurrentImageNumber;
    public static string[] ImageNames = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "O" };
    public static List<int> previous = new List<int>();
    public static void Initialize()
    {
        while (previous.Count < 3)
        {
            CurrentImageNumber = Random.Range(0, ImageNames.Length - 1);
            if (!previous.Contains(CurrentImageNumber))
            {
                previous.Add(CurrentImageNumber);
            }
        }
    }
    public static int GetNextRandomNumber(int count)
    {
        return previous[count];
    }
}