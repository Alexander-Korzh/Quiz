using System.Collections.Generic;
using UnityEngine;

public static class RandomNumbers
{
    public static int CurrentRandomNumber { get; private set; }
    public static List<int> ListOfRandomNumbers { get; private set; }
    public static void CreateList(int InputArrayLength)
    {
        ListOfRandomNumbers = new List<int>();
        while (ListOfRandomNumbers.Count < Logic.GetCellsCount())
        {
            CurrentRandomNumber = Random.Range(0, InputArrayLength);
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
    public static int GetRandomCellNumber()
    {
        return Random.Range(0, Logic.GetCellsCount());
    }
}