using UnityEngine;

public class RandomSprite : MonoBehaviour
{
    [SerializeField]
    private InputImages inputImages;
    private void Start()
    {
        inputImages = gameObject.GetComponent<InputImages>();
    }
    public Sprite Create(int cellNumber)
    {
        var imageNumber = RandomNumbers.GetFromList(cellNumber);
        return inputImages.GetImage(imageNumber);
    }
}
