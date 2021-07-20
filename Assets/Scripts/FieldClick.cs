using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldClick : MonoBehaviour
{
    public static int taskNumber = TaskConstructor.taskNumber;
    void OnMouseDown()
    {
        var g = transform.GetComponentInParent<RandomSprite>();
        if (g.CurrentNumber == taskNumber) Debug.Log("ÏĞÀÂÈËÜÍÎ");
    }
}
