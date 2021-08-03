using System.Collections.Generic;
using UnityEngine;
/// <summary>
///   ласс дл€ создани€ списка рандомных неповтор€ющихс€ номеров
/// </summary>
public static class RandomNumbers
{
    private static int CurrentRandomNumber;
    private static List<int> ListOfRandomNumbers;
    public static void CreateList(int InputListCount)
    {
        ListOfRandomNumbers = new List<int>();
        while (ListOfRandomNumbers.Count < Logic.GetCellsCount())
        {
            CurrentRandomNumber = Random.Range(0, InputListCount);
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