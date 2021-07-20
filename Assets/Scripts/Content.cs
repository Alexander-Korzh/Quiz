using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Content : MonoBehaviour
{
    public void InsertRandomSprite()
    {
        var content = transform.GetChild(1).gameObject;
        var randomSprite = gameObject.GetComponent<RandomSprite>();
        content.GetComponent<Image>().sprite = randomSprite.Create();
    }
}