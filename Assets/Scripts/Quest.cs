using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public static int CorrectCellNumber { get; private set; }
    public static int taskNumber;
    public static List<int> previousTaskNumbers = new List<int>();
    public Text text;
    public static string task = "";
    public void Create()
    {
        CorrectCellNumber = Random.Range(0, Logic.GetCellsCount());
        taskNumber = RandomNumbers.GetFromList(CorrectCellNumber);
        previousTaskNumbers.Add(taskNumber);
        task = "FIND " + Logic.GetImageName(taskNumber);
        Debug.Log("Правильный ответ будет " + taskNumber);
    }
    public static int GetTaskNumber()
    {
        return taskNumber;
    }
    public void Write()
    {
        text.text = task;
    }
}
