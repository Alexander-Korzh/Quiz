using UnityEngine;


/// <summary>
///  ����� ��� ���������� ������������ � ���� Content �������
/// </summary>
public class CellImage : MonoBehaviour
{
    #region Fields

    [SerializeField] private SpriteRenderer ImageInCell;
    [SerializeField] private RandomSprite randomSprite;

    #endregion

    #region Methods

    private void Awake() => 
        randomSprite = transform.root.GetComponent<RandomSprite>();

    public virtual void InsertRandom(int cellNumber) => 
        ImageInCell.sprite = randomSprite.Create(cellNumber);

    #endregion
}