using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    #region Properties
    public int TaskNumber { get; private set; }
    public int CorrectCellNumber { get; private set; }

    #endregion

    #region Fields

    [SerializeField] private HashSet<int> previousTaskNumbers;
    [SerializeField] private RandomNumbers randomNumbers;
    [SerializeField] private LevelLogic logic;

    #endregion

    #region Methods

    private void Start() => previousTaskNumbers = new HashSet<int>();
    public virtual void Create() => CorrectCellNumber = CreateCorrectCellNumber();
    public void ClearPreviousTaskNumbers() => previousTaskNumbers.Clear();
    private int CreateCorrectCellNumber(int cellNumber)
    {
        TaskNumber = randomNumbers[cellNumber];

        if (previousTaskNumbers.Contains(TaskNumber))
            cellNumber = CreateCorrectCellNumber();

        if (logic.Level % LevelLogic.MaxLevel == 0)
            ClearPreviousTaskNumbers();

        previousTaskNumbers.Add(TaskNumber);

        return cellNumber;
    }
    public virtual int CreateCorrectCellNumber()
    {
        return CreateCorrectCellNumber(
            Random.Range(0, logic.GetCellsCount()));
    }

    #endregion
}
