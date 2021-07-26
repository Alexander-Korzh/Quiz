using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Events;

public class Field : MonoBehaviour
{
    public GameObject cellPrefab;
    public static List<GameObject> cellsOnField;
    public void Create()
    {
        DestroyField();
        cellsOnField = new List<GameObject>();
        for (int cellNumber = 0; cellNumber < Logic.GetCellsCount(); cellNumber++)
        {
            var cell = Instantiate(cellPrefab, new Vector2(0, 0), Quaternion.identity, gameObject.transform);
            cell.GetComponent<CellConstructor>().CreateCell(cellNumber);
            if ( Logic.GetLevel() == 1 ) cell.GetComponent<Effects>().Bounce();
            cellsOnField.Add(cell);
        }
    }
    public void DestroyField()
    {
        if (cellsOnField != null)
        {
            for (int i = 0; i < cellsOnField.Count; i++) Destroy(cellsOnField[i]);
        }
    }
}
