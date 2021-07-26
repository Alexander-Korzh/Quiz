using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Content : MonoBehaviour
{
    public GameObject content;
    public RandomSprite imageInCell;
    public void InsertRandomSprite(int cellNumber)
    {
        content.GetComponent<Image>().sprite = imageInCell.Create(cellNumber);
    }
}