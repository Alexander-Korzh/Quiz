using UnityEngine;

public class CellImage : MonoBehaviour
{
    public SpriteRenderer content;
    private void Start()
    {
        content = gameObject.GetComponent<SpriteRenderer>();
    }
    public void InsertRandom(int cellNumber)
    {
        var ImageByNumber = RandomSprite.Create(cellNumber);
        content.sprite = ImageByNumber;
    }
}