using UnityEngine;

public class CellConstructor : MonoBehaviour
{
    public int cellNumber { get; private set; }
    public void CreateCell (int cellNumber)
    {
        //gameObject.name = CellName.Create(cellNumber); // ����� ��� ���������� �������� �������� �������� ������. �������� ����
        this.cellNumber = cellNumber;
        gameObject.transform.localPosition = CellPosition.Create(cellNumber);
        gameObject.GetComponent<CellImage>().InsertRandom(cellNumber);
    }
}
