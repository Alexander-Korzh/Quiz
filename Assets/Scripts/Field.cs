using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public GameObject cellPrefab;
    public static List<GameObject> cellsOnField;
    public void Create()
    {
        Destroy();
        cellsOnField = new List<GameObject>();
        for (int cellNumber = 0; cellNumber < Logic.GetCellsCount(); cellNumber++)
        {
            var cell = Instantiate(cellPrefab, new Vector2(0, 0), Quaternion.identity, gameObject.transform);
            cell.GetComponent<CellConstructor>().CreateCell(cellNumber);
            if (Logic.GetLevel() == 1)
                cell.GetComponent<BounceEffect>().DoBounce();
            cellsOnField.Add(cell);
        }
        Debug.Log("Поле создано");
    }
    public void Destroy()
    {
        if (cellsOnField != null)
            for (int i = 0; i < cellsOnField.Count; i++) Destroy(cellsOnField[i]);
    }
}
