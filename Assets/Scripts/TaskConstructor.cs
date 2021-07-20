using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskConstructor : MonoBehaviour
{
    public static int answerNumber;
    public static int taskNumber;
    public static string task = "";
    public void Answer()
    {
        answerNumber = Random.Range(0, 2);
        taskNumber = RandomNumbers.previous[answerNumber];
        task = "FIND " + RandomNumbers.ImageNames[taskNumber];
        var f = transform.GetChild(0);
        var t = f.GetComponent<Text>();
        t.text = task;
    }
}
