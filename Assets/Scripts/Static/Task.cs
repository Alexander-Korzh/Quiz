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
        CorrectCellNumber = CheckPreviousAnswers(RandomNumbers.GetRandomCellNumber());
        TaskNumber = RandomNumbers.GetFromList(CorrectCellNumber);
        previousTaskNumbers.Add(TaskNumber);
        TaskText = "Find " + Logic.GetImageName(TaskNumber);
        Debug.Log("Правильный ответ будет под номером" + TaskNumber);
    }
    public static int CheckPreviousAnswers(int CorrectCellNumber)
    {
        if (previousTaskNumbers.Contains(CorrectCellNumber))
            CorrectCellNumber = CheckPreviousAnswers(RandomNumbers.GetRandomCellNumber());
        return CorrectCellNumber;
    }
}
