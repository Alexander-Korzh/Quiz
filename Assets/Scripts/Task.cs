using System.Collections.Generic;
using UnityEngine;

public static class Task 
{
    private static List<int> previousTaskNumbers = new List<int>();
    private static int CorrectCellNumber;
    private static int TaskNumber;
    private static string TaskText = "";
    private static string CorrectImageName  = "";
    public static void Create()
    {
        CorrectCellNumber = CreateCorrectCellNumber();
        TaskNumber = RandomNumbers.GetFromList(CorrectCellNumber);
        previousTaskNumbers.Add(TaskNumber);
        CorrectImageName = InputData.GetImageName(TaskNumber);
        TaskText = "Find " + CorrectImageName;
        Debug.Log("Правильный ответ : " + CorrectImageName);
    }
    public static int CheckPreviousAnswers(int potencialCorrectCellNumber)
    {
        var taskNumber = RandomNumbers.GetFromList(potencialCorrectCellNumber);
        if (previousTaskNumbers.Contains(taskNumber))
            potencialCorrectCellNumber = CreateCorrectCellNumber();
        return potencialCorrectCellNumber;
    }
    private static int CreateCorrectCellNumber()
    {
        return CheckPreviousAnswers(RandomNumbers.GetRandomCellNumber());
    }
    public static int GetCorrectCellNumber()
    {
        return CorrectCellNumber;
    }
    public static List<int> GetPreviousTaskNumbers()
    {
        return previousTaskNumbers;
    }
    public static string GetTaskText()
    {
        return TaskText;
    }
}
