using System;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Class for creating a list of random non-repeating numbers
/// </summary>

public class RandomNumbers : MonoBehaviour
{
    #region Fields

    [SerializeField] private LevelLogic logic;
    [SerializeField] private List<int> ListOfRandomNumbers;

    #endregion

    #region Methods

    private void Start() => ListOfRandomNumbers = new List<int>(LevelLogic.MaxCellsCount);
    public void CreateList(int InputListCount)
    {
        ListOfRandomNumbers.Clear();

        while (ListOfRandomNumbers.Count < logic.GetCellsCount())
        {
            int CurrentRandomNumber = UnityEngine.Random.Range(0, InputListCount);

            if (!ListOfRandomNumbers.Contains(CurrentRandomNumber))
            {
                ListOfRandomNumbers.Add(CurrentRandomNumber);
            }
        }
    }
    public int this[int index]
    {
        get
        {
            if (index < 0 || index >= ListOfRandomNumbers.Count) throw new IndexOutOfRangeException();
            return ListOfRandomNumbers[index];
        }
    }

    #endregion
}