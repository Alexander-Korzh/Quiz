using System;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///  ����� ��� �������� ������ ��������� ��������������� �������
/// </summary>
public class RandomNumbers : MonoBehaviour
{
    [SerializeField]
    private List<int> ListOfRandomNumbers;
    [SerializeField]
    private LevelLogic logic;
    private void Start()
    {
        ListOfRandomNumbers = new List<int>(LevelLogic.MaxCellsCount);
        logic = gameObject.GetComponent<LevelLogic>();
    }
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
}