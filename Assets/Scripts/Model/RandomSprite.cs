using UnityEngine;

public class RandomSprite : MonoBehaviour
{
    #region Fields

    [SerializeField] private InputImages inputImages;
    [SerializeField] private RandomNumbers randomNumbers;

    #endregion

    #region Methods
    public virtual Sprite Create(int cellNumber)
    {
        return inputImages.GetImage(
            randomNumbers[cellNumber]);
    }

    #endregion
}
