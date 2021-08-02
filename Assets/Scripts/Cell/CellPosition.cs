using UnityEngine;

public static class CellPosition 
{
    public static Vector2 localPosition { get; private set; }
    public static float CellPositionX { get; private set; }
    public static float CellPositionY { get; private set; }
    public static float CellSizeX { get; private set; } = 0.95f;
    public static float CellSizeY { get; private set; } = 0.95f;
    public static Vector2 Create(int cellNumber)
    {
        var levelCorrection = Logic.Level * CellSizeY - CellSizeX;
        var floatCellNumber = (float)cellNumber;
        switch (cellNumber)
        {
            case 0:
            case 1:
            case 2:
                CellPositionX = floatCellNumber * CellSizeX - CellSizeX;
                CellPositionY = levelCorrection;
                break;
            case 3:
            case 4:
            case 5:
                CellPositionX = floatCellNumber * CellSizeX - CellSizeX * 4;
                CellPositionY = levelCorrection - CellSizeY;
                break;
            case 6:
            case 7:
            case 8:
                CellPositionX = floatCellNumber * CellSizeX - CellSizeX * 7;
                CellPositionY = levelCorrection - CellSizeY * 2;
                break;
        }
        return new Vector2(CellPositionX, CellPositionY);
    }
}
