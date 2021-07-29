using System.Collections.Generic;
using UnityEngine;

public static class Task 
{
    public static List<int> previousTaskNumbers = new List<int>();
    public static int CorrectCellNumber { get; private set; }
    public static int TaskNumber { get; private set; }
    public static string TaskText { get; private set; } = "";
    public static void Create()
    {
        CorrectCellNumber = Random.Range(0, Logic.GetCellsCount());
        TaskNumber = RandomNumbers.GetFromList(CorrectCellNumber);
        previousTaskNumbers.Add(TaskNumber);
        TaskText = "FIND " + Logic.GetImageName(TaskNumber);
        Debug.Log("Правильный ответ будет под номером" + TaskNumber);
    }
}
