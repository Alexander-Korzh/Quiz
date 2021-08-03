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
    private List<GameObject> cellsOnField = new List<GameObject>();
    public IEnumerator Create()
    {
        AddCells();
        for (int cellNumber = 0; cellNumber < Logic.GetCellsCount(); cellNumber++)
        {
            var cell = cellsOnField[cellNumber];
            var cellConstructor = cell.GetComponent<CellConstructor>();
            cellConstructor.CreateCell(cellNumber);
            if (Logic.GetLevel() == 1)
                cell.GetComponent<BounceEffect>().DoBounce();
        }
        Debug.Log("Поле создано");
        yield return null;
    }
    public void Destroy()
    {
        if (cellsOnField != null)
            for (int i = 0; i < cellsOnField.Count; i++) Destroy(cellsOnField[i]);
        cellsOnField = new List<GameObject>();
    }
    public void AddCells()
    {
        for (int i = 0; i < Logic.CellsInLineCount; i++)
        {
            var cell = Instantiate(cellPrefab, new Vector2(0, 0), Quaternion.identity, gameObject.transform);
            cellsOnField.Add(cell);
            Debug.Log("Клетка добавлена в поле под номером " + cellsOnField[i]);
        }
    }
}
