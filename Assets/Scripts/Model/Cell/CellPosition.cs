using UnityEngine;


public class CellPosition : MonoBehaviour
{
    #region Fields

    [SerializeField] private float cellSizeX = 0.95f; //
    [SerializeField] private float cellSizeY = 0.95f; //Не гибко, поправить //P.S. Через ScriptableObject
    [SerializeField] private LevelLogic logic;

    #endregion

    #region Methods

    public  Vector2 Create(int cellNumber)
    {
        var positionX = cellSizeX * ( cellNumber - ( (LevelLogic.CellsInLineCount - 1)  / 2 ) );
        var positionY = cellSizeY * (logic.Level - 1 );

        return new Vector2(positionX, positionY);
    }

    #endregion
}
