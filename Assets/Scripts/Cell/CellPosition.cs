using UnityEngine;

public static class CellPosition 
{
    private static float cellPositionX;
    private static float cellPositionY;
    private static float cellSizeX = 0.95f;
    private static float cellSizeY = 0.95f;
    public static Vector2 Create(int cellNumber)
    {
        var levelCorrection = Logic.GetLevel() * cellSizeY - cellSizeX;
        var floatCellNumber = (float)cellNumber;
        switch (cellNumber)
        {
            case 0:
            case 1:
            case 2:
                cellPositionX = cellSizeX * ( floatCellNumber - 1 );
                cellPositionY = levelCorrection;
                break;
            case 3:
            case 4:
            case 5:
                cellPositionX = cellSizeX * ( floatCellNumber - 4 );
                cellPositionY = levelCorrection - cellSizeY;
                break;
            case 6:
            case 7:
            case 8:
                cellPositionX = cellSizeX * ( floatCellNumber - 7 );
                cellPositionY = levelCorrection - cellSizeY * 2;
                break;
        }
        return new Vector2(cellPositionX, cellPositionY);
    }
}
