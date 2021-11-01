using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    public int TaskNumber { get; private set; }
    public int CorrectCellNumber { get; private set; }
    [SerializeField]
    private HashSet<int> previousTaskNumbers;
    [SerializeField]
    private RandomNumbers randomNumbers;
    [SerializeField]
    private LevelLogic logic;
    private void Start()
    {
        previousTaskNumbers = new HashSet<int>();
        randomNumbers = gameObject.GetComponent<RandomNumbers>();
        logic = gameObject.GetComponent<LevelLogic>();
    }
    public virtual void Create()
    {
        CorrectCellNumber = CreateCorrectCellNumber();
        //Debug.Log("Правильный ответ : " + correctImageName);
    }
    private int CreateCorrectCellNumber(int cellNumber)
    {
        TaskNumber = randomNumbers[cellNumber];
        if (previousTaskNumbers.Contains(TaskNumber))
            cellNumber = CreateCorrectCellNumber();
        previousTaskNumbers.Add(TaskNumber);
        return cellNumber;
    }
    public virtual int CreateCorrectCellNumber()
    {
        return CreateCorrectCellNumber(
            Random.Range(0, logic.GetCellsCount()));
    }
    public void ClearPreviousTaskNumbers()
    {
        previousTaskNumbers.Clear();
    }
}
