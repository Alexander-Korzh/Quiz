using UnityEngine;

public class CellConstructor : MonoBehaviour, ICell
{
    #region Fields

    [SerializeField] private CellData cellData;
    [SerializeField] private CellImage cellImage;

    #endregion

    #region Methods

    public void UpdateCell(int cellNumber)
    {
        SetNumber(cellNumber);

        SetImage();
    }
    public void SetNumber(int cellNumber) => cellData.SetNumber(cellNumber);
    public void SetImage()
    {
        cellImage.InsertRandom(
            cellData.Number);
    }

    #endregion
}
