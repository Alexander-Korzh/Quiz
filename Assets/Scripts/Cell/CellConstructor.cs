using UnityEngine;

public class CellConstructor : MonoBehaviour
{
    [SerializeField]
    private int cellNumber;
    public void CreateCell (int cellNumber)
    {
        //gameObject.name = CellName.Create(cellNumber); // Метод для именования логичных названий префабов клеток. Тормозит игру
        this.cellNumber = cellNumber;
        gameObject.transform.localPosition = CellPosition.Create(cellNumber);
        gameObject.GetComponent<CellImage>().InsertRandom(cellNumber);
        Debug.Log("Клетка " + cellNumber + " создана");
    }
    public int GetCellNumber()
    {
        return cellNumber;
    }
}
