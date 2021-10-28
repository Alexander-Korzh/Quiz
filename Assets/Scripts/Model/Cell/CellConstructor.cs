using UnityEngine;

public class CellConstructor : MonoBehaviour, ICell
{
    [SerializeField]
    private CellData cellData;
    [SerializeField]
    private CellImage cellImage;
    private void Awake()
    {
        cellData = gameObject.GetComponent<CellData>();
        cellImage = gameObject.GetComponent<CellImage>();
    }
    public void UpdateCell(int cellNumber)
    {
        SetNumber(cellNumber);
        SetImage();
        //Debug.Log("������ " + cellNumber + " �������");
    }
    public void SetNumber(int cellNumber) => cellData.SetNumber(cellNumber);
    public void SetImage()
    {
        cellImage.InsertRandom(
            cellData.Number);
    }
}
