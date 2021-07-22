using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskConstructor : MonoBehaviour
{
    public static int correctCellNumber;
    public static int taskNumber;
    public static string task = "";
    public void Answer()
    {
        correctCellNumber = Random.Range(0, Logic.GetCellsCount());
        taskNumber = RandomNumbers.GetFromList(correctCellNumber);
        task = "FIND " + Logic.GetImageName(taskNumber);
        var f = transform.GetChild(0);
        var t = f.GetComponent<Text>();
        t.text = task;
        Debug.Log("Правильный ответ будет " + taskNumber);
    }
    public static int GetTaskNumber()
    {
        return taskNumber;
    }
}
