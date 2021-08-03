using UnityEngine;

public class CellConstructor : MonoBehaviour
{
    [SerializeField]
    private int cellNumber;
    public void CreateCell (int cellNumber)
    {
        //gameObject.name = CellName.Create(cellNumber); // ����� ��� ���������� �������� �������� �������� ������. �������� ����
        this.cellNumber = cellNumber;
        gameObject.transform.localPosition = CellPosition.Create(cellNumber);
        gameObject.GetComponent<CellImage>().InsertRandom(cellNumber);
        Debug.Log("������ " + cellNumber + " �������");
    }
    public int GetCellNumber()
    {
        return cellNumber;
    }
}
