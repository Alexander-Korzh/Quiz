using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public static int CorrectCellNumber { get; private set; }
    public static int TaskNumber { get; private set; }
    public static List<int> previousTaskNumbers = new List<int>();
    public Text gameObjectWithText;
    public static string task = "";
    public void Create()
    {
        CorrectCellNumber = Random.Range(0, Logic.GetCellsCount());
        TaskNumber = RandomNumbers.GetFromList(CorrectCellNumber);
        previousTaskNumbers.Add(TaskNumber);
        task = "FIND " + Logic.GetImageName(TaskNumber);
        Debug.Log("Правильный ответ будет под номером" + TaskNumber);
    }
    public void Write()
    {
        gameObjectWithText.text = task;
    }
}
