using System;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///   ласс дл€ создани€ списка рандомных неповтор€ющихс€ номеров
/// </summary>
public class RandomNumbers : MonoBehaviour
{
    [SerializeField]
    private LevelLogic logic;
    [SerializeField]
    private List<int> ListOfRandomNumbers;
    private void Start()
    {
        logic = gameObject.GetComponent<LevelLogic>();
        ListOfRandomNumbers = new List<int>(LevelLogic.MaxCellsCount);
    }
    public virtual void CreateList(int InputListCount)
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
}