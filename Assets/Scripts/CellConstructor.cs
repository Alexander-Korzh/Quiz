using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class CellConstructor : MonoBehaviour
{
    public Vector2 localPosition { get; private set; }
    public int xPosition { get; private set; }
    public int yPosition { get; private set; }
    public int Size { get; private set; }
    public CellConstructor()
    {
        Size = 95;
    }
    public void CreatePosition(int cellNumber)
    {
        var levelCorrection = Logic.GetLevel()*Size - Size;
        switch (cellNumber)
        {
            case 0:
            case 1:
            case 2:
                xPosition = cellNumber * Size - Size;
                yPosition = levelCorrection;
                break;
            case 3:
            case 4:
            case 5:
                xPosition = cellNumber * Size - Size * 4;
                yPosition = levelCorrection - Size;
                break;
            case 6:
            case 7:
            case 8:
                xPosition = cellNumber * Size - Size * 7;
                yPosition = levelCorrection - Size * 2;
                break;
        }
        localPosition = new Vector2(xPosition, yPosition);
        gameObject.transform.localPosition = localPosition;
    }
    public void CreateName  (int cellNumber)
    {
        switch (cellNumber)
        {
            case 0:
                gameObject.name = "left top cell";
                break;
            case 1:
                gameObject.name = "center top cell";
                break;
            case 2:
                gameObject.name = "right top cell";
                break;
            case 3:
                gameObject.name = "left middle cell";
                break;
            case 4:
                gameObject.name = "center middle cell";
                break;
            case 5:
                gameObject.name = "right middle cell";
                break;
            case 6:
                gameObject.name = "left bottom cell";
                break;
            case 7:
                gameObject.name = "center bottom cell";
                break;
            case 8:
                gameObject.name = "right bottom cell";
                break;
        }
    }
    public void CreateSprite (int cellNumber)
    {
        gameObject.GetComponent<Content>().InsertRandomSprite(cellNumber);
    }
    public void CreateCell (int cellNumber)
    {
        CreateName(cellNumber);
        CreatePosition(cellNumber);
        CreateSprite(cellNumber);
    }
}
