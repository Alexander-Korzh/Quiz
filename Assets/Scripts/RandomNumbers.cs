using System.Collections.Generic;
using UnityEngine;
/// <summary>
///   ласс дл€ создани€ списка рандомных неповтор€ющихс€ номеров
/// </summary>
public class RandomNumbers : MonoBehaviour
{
    [SerializeField]
    private int CurrentRandomNumber;
    [SerializeField]
    private List<int> ListOfRandomNumbers;
    [SerializeField]
    private LevelLogic logic;
    private void Start()
    {
        logic = gameObject.GetComponent<LevelLogic>();
    }
    public void CreateList(int InputListCount)
    {
        ListOfRandomNumbers = new List<int>();
        Debug.Log(logic);
        while (ListOfRandomNumbers.Count < logic.GetCellsCount())
        {
            CurrentRandomNumber = Random.Range(0, InputListCount);
            if (!ListOfRandomNumbers.Contains(CurrentRandomNumber))
            {
                ListOfRandomNumbers.Add(CurrentRandomNumber);
            }
        }
    }
    public int GetFromList(int indexOfRandomNumber)
    {
        return ListOfRandomNumbers[indexOfRandomNumber];
    }
    public int GetRandomCellNumber()
    {
        return Random.Range(0, logic.GetCellsCount());
    }
    public void ClearList()
    {
        ListOfRandomNumbers.Clear();
    }
}