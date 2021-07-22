using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Events;

public class Cell : MonoBehaviour
{
    public GameObject cellPrefab;
    public static List<GameObject> cells;
    public void CreateField()
    {
        cells = new List<GameObject>();
        //DestroyCell.ToDestroy();
        for (int cellNumber = 0; cellNumber < Logic.GetCellsCount(); cellNumber++)
        {
            var cell = Instantiate(cellPrefab, new Vector2(0, 0), Quaternion.identity, gameObject.transform);
            cell.transform.localPosition = new Vector2(CreatePosition(cellNumber)[0], CreatePosition(cellNumber)[1]);
            CreateName(cell, cellNumber);
            //var f = cell.GetComponent<Effects>();
            //f.Bounce();
            cells.Add(cell);
            var content = cell.GetComponent<Content>();
            content.InsertRandomSprite(cellNumber);
        }
    }
    public static int[] CreatePosition(int cellNumber)
    {
        int x = 0;
        int y = 0;
        switch (cellNumber)
        {
            case 0:
            case 1:
            case 2:
                x = cellNumber * 95 - 95;
                y = 0;
                break;
            case 3:
            case 4:
            case 5:
                x = cellNumber * 95 - 95*4;
                y = -95;
                break;
            case 6:
            case 7:
            case 8:
                x = cellNumber * 95 - 95*7;
                y = -95 * 2;
                break;
        }
        return new[] { x, y };

    }
    public static void CreateName(GameObject cell, int cellNumber)
    {
        switch (cellNumber)
        {
            case 0:
                cell.name = "left top cell";
                break;
            case 1:
                cell.name = "center top cell";
                break;
            case 2:
                cell.name = "right top cell";
                break;
            case 3:
                cell.name = "left middle cell";
                break;
            case 4:
                cell.name = "center middle cell";
                break;
            case 5:
                cell.name = "right middle cell";
                break;
            case 6:
                cell.name = "left bottom cell";
                break;
            case 7:
                cell.name = "center bottom cell";
                break;
            case 8:
                cell.name = "right bottom cell";
                break;
        }
    }
    public static void DestroyFeild()
    {
        for (int i = 0; i < cells.Count; i++) Destroy(cells[i]);
    }
}
