using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///  Class for creating and work with field of cells
/// </summary>


[RequireComponent(typeof(LevelLogic))]
[RequireComponent(typeof(CellPosition))]

public class Field : MonoBehaviour
{
    #region Fields

    [SerializeField] private GameObject cellPrefab;
    [SerializeField] private List<GameObject> cells = new List<GameObject>(LevelLogic.MaxCellsCount);
    [SerializeField] private CellPosition cellInLinePosition;
    [SerializeField] private LevelLogic logic;

    #endregion

    #region Methods

    public IEnumerator Create<T>(Action<GameObject> firstLevelAction) where T : ICell
    {

        if (logic.Level <= LevelLogic.MaxLevel) AddCells();

        for (int cellNumber = 0; cellNumber < cells.Count; cellNumber++)
        {
            GameObject cell = cells[cellNumber];

            cell.GetComponent<T>()          // There is a situation, 
                .UpdateCell(cellNumber);    // where we have to be sure that prefab has this component,
                                            // But now it looks like polymorphism. Figure out
            if (logic.Level == 1) firstLevelAction(cell);

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
        }
    }

    #endregion
}
