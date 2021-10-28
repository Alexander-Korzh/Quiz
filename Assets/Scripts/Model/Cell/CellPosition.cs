using UnityEngine;

public class CellPosition : MonoBehaviour
{
    private static float cellSizeX = 0.95f; //Не гибко, поправить;
    private static float cellSizeY = 0.95f;
    [SerializeField]
    private LevelLogic logic;
    private void Start() => logic = gameObject.GetComponent<LevelLogic>();
    public  Vector2 Create(int cellNumber)
    {
        var positionX = cellSizeX * ( cellNumber - ( (LevelLogic.CellsInLineCount - 1)  / 2 ) );
        var positionY = cellSizeY * (logic.Level - 1 );
        return new Vector2(positionX, positionY);
    }
}
