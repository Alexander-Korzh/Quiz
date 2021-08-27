using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    [SerializeField]
    public int taskNumber;
    [SerializeField]
    private int correctCellNumber;
    [SerializeField]
    private List<int> previousTaskNumbers;
    [SerializeField]
    private RandomNumbers randomNumbers;
    private void Start()
    {
        previousTaskNumbers = new List<int>(LevelLogic.MaxLevel);
        randomNumbers = gameObject.GetComponent<RandomNumbers>();
    }
    public void Create()
    {
        correctCellNumber = CreateCorrectCellNumber();
        previousTaskNumbers.Add(taskNumber);
        //Debug.Log("Правильный ответ : " + correctImageName);
    }
    public int CreateCorrectCellNumber(int cellNumber)
    {
        taskNumber = randomNumbers.GetFromList(cellNumber);
        if (previousTaskNumbers.Contains(taskNumber))
            cellNumber = CreateCorrectCellNumber();
        return cellNumber;
    }
    public int CreateCorrectCellNumber()
    {
        int randomCellNumber = randomNumbers.GetRandomCellNumber();
        return CreateCorrectCellNumber(randomCellNumber);
    }
    public int GetCorrectCellNumber()
    {
        return correctCellNumber;
    }
    public void ClearPreviousTaskNumbers()
    {
        previousTaskNumbers.Clear();
    }
}
