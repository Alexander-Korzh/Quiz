using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///  Класс для работы с полем из клеток
/// </summary>
[RequireComponent(typeof(LevelLogic))]
[RequireComponent(typeof(CellPosition))]
public class Field : MonoBehaviour
{
    public GameObject cellPrefab;
    [SerializeField]
    private List<GameObject> cells = new List<GameObject>(LevelLogic.MaxCellsCount);
    [SerializeField]
    private CellPosition cellInLinePosition;
    [SerializeField]
    private LevelLogic logic;
    private void Start()
    {
        cellInLinePosition = gameObject.GetComponent<CellPosition>();
        logic = gameObject.GetComponent<LevelLogic>();
    }
    public IEnumerator Create<T>(Action<GameObject> firstLevelAction) where T : ICell
    {
        AddCells();
        for (int cellNumber = 0; cellNumber < cells.Count; cellNumber++)
        {
            GameObject cell = cells[cellNumber];
            cell.GetComponent<T>()  // Тут получается, что мы должны быть уверены в наличии этого компонента у префаба
                .UpdateCell(cellNumber);
            if (logic.Level == 1)
                firstLevelAction(cell);
            yield return null;
        }
        //Debug.Log("Поле создано");
    }
    public void Destroy()
    {
        if (cells != null)
            for (int i = 0; i < cells.Count; i++) Destroy(cells[i]);
        cells = new List<GameObject>(LevelLogic.MaxCellsCount);
    }
    public void AddCells()
    {
        for (int cellInLineNumber = 0; cellInLineNumber < LevelLogic.CellsInLineCount; cellInLineNumber++)
        {
            GameObject cell = Instantiate(
                cellPrefab, 
                cellInLinePosition.Create(cellInLineNumber), 
                Quaternion.identity, 
                gameObject.transform);
            cells.Add(cell);
            //Debug.Log("Клетка добавлена в поле под номером " + cellNumber);
        }
    }
}
