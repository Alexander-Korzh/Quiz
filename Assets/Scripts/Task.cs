using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    [SerializeField]
    private int TaskNumber;
    [SerializeField]
    private int CorrectCellNumber;
    [SerializeField]
    private string TaskText = "";
    [SerializeField]
    private string CorrectImageName  = "";
    [SerializeField]
    private InputImages inputImages;
    [SerializeField]
    private List<int> previousTaskNumbers = new List<int>();
    [SerializeField]
    private RandomNumbers randomNumbers;
    private void Start()
    {
        inputImages = gameObject.GetComponent<InputImages>();
        randomNumbers = gameObject.GetComponent<RandomNumbers>();
    }
    public void Create()
    {
        CorrectCellNumber = CreateCorrectCellNumber();
        TaskNumber = randomNumbers.GetFromList(CorrectCellNumber);
        previousTaskNumbers.Add(TaskNumber);
        CorrectImageName = inputImages.GetImageName(TaskNumber);
        TaskText = "Find " + CorrectImageName;
        Debug.Log("Правильный ответ : " + CorrectImageName);
    }
    public int CheckPreviousAnswers(int potencialCorrectCellNumber)
    {
        var taskNumber = randomNumbers.GetFromList(potencialCorrectCellNumber);
        if (previousTaskNumbers.Contains(taskNumber))
            potencialCorrectCellNumber = CreateCorrectCellNumber();
        return potencialCorrectCellNumber;
    }
    private int CreateCorrectCellNumber()
    {
        var randomCellNumber = randomNumbers.GetRandomCellNumber();
        return CheckPreviousAnswers(randomCellNumber);
    }
    public int GetCorrectCellNumber()
    {
        return CorrectCellNumber;
    }
    public string GetTaskText()
    {
        return TaskText;
    }
    public void ClearPreviousTaskNumbers()
    {
        previousTaskNumbers.Clear();
    }
}
