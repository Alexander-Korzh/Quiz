using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour
{
    public GameObject RestartButton;
    public static int level = 1;
    private static string[] ImageNames = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "O", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z" };
    void Start()
    {
        Initialize();
    }
    public static int GetCellsCount()
    {
        return level * 3;
    }
    public static string GetImageName(int indexInArray)
    {
        return ImageNames[indexInArray];
    }
    public static void Initialize()
    {
        RandomNumbers.Initialize(ImageNames.Length - 1);
    }
    public void Restart()
    {
        RestartButton.SetActive(true);
    }
}
