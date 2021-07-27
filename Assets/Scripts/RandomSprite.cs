using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprite : MonoBehaviour
{
    public int ImageNumber { get; private set; }
    public Sprite Create(int cellNumber)
    {
        ImageNumber = RandomNumbers.GetFromList(cellNumber);
        var name = Logic.GetImageName(ImageNumber);
        return Resources.Load<Sprite>(name);
    }
}
