using System.Collections.Generic;
using UnityEngine;
/// <summary>
///   ласс дл€ создани€ списка рандомных неповтор€ющихс€ номеров
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
            int CurrentRandomNumber = Random.Range(0, InputListCount);
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
}