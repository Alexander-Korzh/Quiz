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
        var cellImage = gameObject.GetComponent<CellImage>();
        cellImage.InsertRandom(cellNumber);
        EnableCollider();
        Debug.Log("Клетка " + cellNumber + " создана");
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
