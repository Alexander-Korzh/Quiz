using UnityEngine;

public class RandomSprite : MonoBehaviour
{
    [SerializeField]
    private InputImages inputImages;
    [SerializeField]
    private RandomNumbers randomNumbers;
    private void Start()
    {
        inputImages = gameObject.GetComponent<InputImages>();
        randomNumbers = gameObject.GetComponent<RandomNumbers>();
    }
    public Sprite Create(int cellNumber)
    {
        var imageNumber = randomNumbers.GetFromList(cellNumber);
        return inputImages.GetImage(imageNumber);
    }
}
