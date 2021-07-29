using System.Collections.Generic;
using UnityEngine;

public static class RandomNumbers
{
    public static int CurrentRandomNumber { get; private set; }
    public static List<int> ListOfRandomNumbers;
    public static void Initialize(int maxRandomNumber)
    {
        ListOfRandomNumbers = new List<int>();
        while (ListOfRandomNumbers.Count < Logic.GetCellsCount())
        {
            CurrentRandomNumber = Random.Range(0, maxRandomNumber);
            if (!ListOfRandomNumbers.Contains(CurrentRandomNumber))
            {
                ListOfRandomNumbers.Add(CurrentRandomNumber);
            }
        }
    }
    public static int GetFromList(int indexOfRandomNumber)
    {
        return ListOfRandomNumbers[indexOfRandomNumber];
    }
}