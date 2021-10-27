using UnityEngine;
/// <summary>
///  Класс для управления изображением в поле Content префаба
/// </summary>
public class CellImage : Content
{
    [SerializeField]
    private SpriteRenderer ImageInCell;
    [SerializeField]
    private RandomSprite randomSprite;
    private void Awake()
    {
        randomSprite = transform.root.GetComponent<RandomSprite>();
        ImageInCell = content.GetComponent<SpriteRenderer>();
    }
    public void InsertRandom(int cellNumber)
    {
        var ImageByNumber = randomSprite.Create(cellNumber);
        ImageInCell.sprite = ImageByNumber;
    }
}