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
    private void Start()
    {
        inputImages = gameObject.GetComponent<InputImages>();
    }
    public void Create()
    {
        CorrectCellNumber = CreateCorrectCellNumber();
        TaskNumber = RandomNumbers.GetFromList(CorrectCellNumber);
        previousTaskNumbers.Add(TaskNumber);
        CorrectImageName = inputImages.GetImageName(TaskNumber);
        TaskText = "Find " + CorrectImageName;
        Debug.Log("Правильный ответ : " + CorrectImageName);
    }
    public int CheckPreviousAnswers(int potencialCorrectCellNumber)
    {
        var taskNumber = RandomNumbers.GetFromList(potencialCorrectCellNumber);
        if (previousTaskNumbers.Contains(taskNumber))
            potencialCorrectCellNumber = CreateCorrectCellNumber();
        return potencialCorrectCellNumber;
    }
    private int CreateCorrectCellNumber()
    {
        return CheckPreviousAnswers(RandomNumbers.GetRandomCellNumber());
    }
    public  int GetCorrectCellNumber()
    {
        return CorrectCellNumber;
    }
    public List<int> GetPreviousTaskNumbers()
    {
        return previousTaskNumbers;
    }
    public string GetTaskText()
    {
        return TaskText;
    }
}
