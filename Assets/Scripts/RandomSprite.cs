using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprite : MonoBehaviour
{
    public string[] ImageNames = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "O" };
    //public List<int> previous;
    public static int count;
    public int CurrentNumber;
    public Sprite Create()
    {
        CurrentNumber = RandomNumbers.GetNextRandomNumber(count);
        var name = ImageNames[CurrentNumber];
        count++;
        return Resources.Load<Sprite>(name);
    }
}
