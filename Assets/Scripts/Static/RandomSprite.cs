using UnityEngine;

public static class RandomSprite 
{
    public static Sprite Create(int cellNumber)
    {
        var imageNumber = RandomNumbers.GetFromList(cellNumber);
        var name = Logic.GetImageName(imageNumber);
        return Resources.Load<Sprite>(name);
    }
}
