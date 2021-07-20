using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour
{
    public int level;
    void Start()
    {
        level = 0;
        RandomNumbers.Initialize();
        var task = transform.GetComponent<TaskConstructor>();
        task.Answer();
    }
}
