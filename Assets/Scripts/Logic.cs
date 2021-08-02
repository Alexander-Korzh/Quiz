using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Logic : MonoBehaviour
{
    public const int cellsInLineCount = 3;
    public const int maxLevel = 3;
    public Field field;
    public TaskField taskField;
    public UnityEvent restart;
    public static int Level { get; private set; } = 0;
    private static string[] ImageNames = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "O", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z" };
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
        RandomNumbers.CreateList(ImageNames.Length - 1);
        Task.Create();
        StartCoroutine(taskField.ChangeText());
        field.Create();
    }
    public void Restart()
    {
        Task.previousTaskNumbers.Clear();
        Level = 0;
        restart.Invoke();
    }
    public IEnumerator RestartWithDelayCoroutine(float delayInSeconds)
    {
        yield return new WaitForSeconds(delayInSeconds);
        Restart();
    }
    public void RestartWithDelay(float delayInSeconds)
    {
        StartCoroutine(RestartWithDelayCoroutine(delayInSeconds));
    }
}