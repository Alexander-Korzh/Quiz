using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Logic : MonoBehaviour
{
    public const int cellsInLineCount = 3;
    public const int maxLevel = 3;
    public Field field;
    public GameObject RestartPlane;
    public GameObject RestartButton;
    public ParticleSystem psystem;
    public TextEffects taskEffects;
    public Text taskText;
    public Image plane;
    public UnityEvent restart;
    public RectTransform planeRectTransform;
    public static int Level { get; private set; }
    private static string[] ImageNames = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "O", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z" };
    void Start()
    {
        plane.color = new Color(0, 0, 0, 0);
        taskText.color = new Color(1, 1, 1, 0);
        Level = 0;
    }
    public static int GetCellsCount()
    {
        return Level * cellsInLineCount;
    }
    public static string GetImageName(int indexInArray)
    {
        return ImageNames[indexInArray];
    }
    public void NextLevel()
    {
        Level++;
        RandomNumbers.Initialize(ImageNames.Length - 1);
        Task.Create();
        StartCoroutine(taskEffects.ChangeTextWithFade());
        field.Create();
    }
    public void Restart()
    {
        restart.Invoke();
        Level = 0;
    }
    public IEnumerator RestartWithDelay(float delayInSeconds)
    {
        planeRectTransform.SetAsLastSibling();
        yield return new WaitForSeconds(delayInSeconds);
        Restart();
    }
}