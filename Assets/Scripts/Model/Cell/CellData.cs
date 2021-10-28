using UnityEngine;

public class CellData : MonoBehaviour
{
    public int Number { get; private set; }
    public void SetNumber(int number) => Number = number;
}
