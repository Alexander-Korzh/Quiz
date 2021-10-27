using UnityEngine;

public class CellConstructor : MonoBehaviour
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
    public void CreateCell (int cellNumber)
    {
        cellData.SetNumber(cellNumber);
        cellImage.InsertRandom(cellNumber);
        //Debug.Log("Клетка " + cellNumber + " создана");
    }
}
