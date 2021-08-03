using UnityEngine;

public class CellConstructor : MonoBehaviour
{
    [SerializeField]
    private int cellNumber;
    [SerializeField]
    private BoxCollider2D contentCollider;

    public void CreateCell (int cellNumber)
    {
        //gameObject.name = CellName.Create(cellNumber); // ����� ��� ���������� �������� �������� �������� ������. �������� ����
        this.cellNumber = cellNumber;
        gameObject.transform.localPosition = CellPosition.Create(cellNumber);
        var cellImage = gameObject.GetComponent<CellImage>();
        cellImage.InsertRandom(cellNumber);
        EnableCollider();
        Debug.Log("������ " + cellNumber + " �������");
    }
    public int GetCellNumber()
    {
        return cellNumber;
    }
    public void EnableCollider()
    {
        if (contentCollider.enabled == false) contentCollider.enabled = true; 
    }
}
