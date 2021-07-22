using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FieldClick : MonoBehaviour
{
    public UnityEvent correctAnswer;
    //public static int taskNumber;
    public void CheckAnswer()
    {
        //taskNumber = TaskConstructor.taskNumber;
        var imageInCell = transform.GetComponent<RandomSprite>();
        if (imageInCell.ImageNumber == TaskConstructor.GetTaskNumber())
        {
            correctAnswer.Invoke();
            Debug.Log("Правильно !!!!!");
            Cell.DestroyFeild();
            Logic.level++;
            Logic.Initialize();
            //if (Logic.level == 4) Logic.level = 1;
        }
    }
}
