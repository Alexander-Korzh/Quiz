using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///  Класс для работы с полем из клеток
/// </summary>
public class Field : MonoBehaviour
{
    public GameObject cellPrefab;
    [SerializeField]
    private List<GameObject> cellsOnField = new List<GameObject>(LevelLogic.MaxCellsCount);
    [SerializeField]
    private CellPosition cellPosition;
    [SerializeField]
    private LevelLogic logic;
    private void Start()
    {
        //cellsOnField = new List<GameObject>(LevelLogic.MaxCellsCount);
        cellPosition = gameObject.GetComponent<CellPosition>();
        logic = gameObject.GetComponent<LevelLogic>();
    }
    public IEnumerator Create()
    {
        AddCells();
        for (int cellNumber = 0; cellNumber < logic.GetCellsCount(); cellNumber++)
        {
            GameObject cell = cellsOnField[cellNumber];
            CellConstructor cellConstructor = cell.GetComponent<CellConstructor>();
            cellConstructor.CreateCell(cellNumber);
            if (logic.Level == 1)
                cell.GetComponent<ScalePuncher>()
                    .PunchScale(0.3f);
        }
        //Debug.Log("Поле создано");
        yield return null;
    }
    public void Destroy()
    {
        if (cellsOnField != null)
            for (int i = 0; i < cellsOnField.Count; i++) Destroy(cellsOnField[i]);
        cellsOnField = new List<GameObject>(LevelLogic.MaxCellsCount);
    }
    public void AddCells()
    {
        for (int cellNumber = 0; cellNumber < LevelLogic.CellsInLineCount; cellNumber++)
        {
            var cell = Instantiate(cellPrefab, cellPosition.Create(cellNumber), Quaternion.identity, gameObject.transform);
            cellsOnField.Add(cell);
            //Debug.Log("Клетка добавлена в поле под номером " + cellNumber);
        }
    }
}
