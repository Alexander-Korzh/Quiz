using UnityEngine;

public class CellPosition : MonoBehaviour
{
    private static float cellSizeX = 0.95f;
    private static float cellSizeY = 0.95f;
    [SerializeField]
    private Logic logic;
    private void Start()
    {
        logic = gameObject.GetComponent<Logic>();
    }
    public  Vector2 Create(int cellNumber)
    {
        var positionX = cellSizeX * ( cellNumber - ( (float)(Logic.CellsInLineCount - 1) ) / 2 );
        var positionY = cellSizeY * (logic.GetLevel() - 1 );
        return new Vector2(positionX, positionY);
    }
}
