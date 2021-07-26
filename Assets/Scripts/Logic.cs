using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Logic : MonoBehaviour
{
    public static int cellsInLineCount { get; private set; }
    public Quest task;
    public Field field;
    public GameObject RestartButton;
    public ParticleSystem psystem;
    public TextEffects taskEffects;
    public Text taskText;
    public static int level;
    private static string[] ImageNames = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "O", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z" };
    void Start()
    {
        //taskText.color = new Color(1,1,1,0);
        cellsInLineCount = 3;
        level = 0;
    }
    public static int GetCellsCount()
    {
        return level * cellsInLineCount;
    }
    public static string GetImageName(int indexInArray)
    {
        return ImageNames[indexInArray];
    }
    public void NextLevel()
    {
        level++;
        RandomNumbers.Initialize(ImageNames.Length - 1);
        psystem.Play();
        task.Create();
        //task.Write();
        StartCoroutine(taskEffects.Appearance());
        field.Create();

    }
    public void Restart()
    {
        field.DestroyField();
    }
    public static int GetLevel()
    {
        return level;
    }
}
