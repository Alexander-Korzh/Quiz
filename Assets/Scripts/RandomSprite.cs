using UnityEngine;

public static class RandomSprite 
{
    public static Sprite Create(int cellNumber)
    {
        var imageNumber = RandomNumbers.GetFromList(cellNumber);
        var name = InputData.GetImageName(imageNumber);
        return Resources.Load<Sprite>(name);
    }
}
