using UnityEngine;
/// <summary>
///  Класс для управления изображением в поле Content префаба
/// </summary>
public class CellImage : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer content;
    [SerializeField]
    private RandomSprite randomSprite;
    public void Start()
    {
        //randomSprite = transform.root.GetComponent<RandomSprite>();
        content = transform.GetChild(1).GetComponent<SpriteRenderer>();
    }
    public void InsertRandom(int cellNumber)
    {
        randomSprite = transform.root.GetComponent<RandomSprite>();
        var ImageByNumber = randomSprite.Create(cellNumber);
        content.sprite = ImageByNumber;
    }
}