using UnityEngine;

public class CellConstructor : MonoBehaviour
{
    [SerializeField]
    private int cellNumber;
    [SerializeField]
    private BoxCollider2D contentCollider;

    public void CreateCell (int cellNumber)
    {
        this.cellNumber = cellNumber;
        CellImage cellImage = gameObject.GetComponent<CellImage>();
        cellImage.InsertRandom(cellNumber);
        //Debug.Log("������ " + cellNumber + " �������");
    }
    public int GetCellNumber()
    {
        return cellNumber;
    }
    public void EnableCollider()
    {
        if (!contentCollider.enabled) 
            contentCollider.enabled = true; 
    }
}
