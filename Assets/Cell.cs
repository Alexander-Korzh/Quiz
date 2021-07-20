using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Events;

public class Cell : MonoBehaviour
{
    public GameObject cell;
    public List<GameObject> cells;
    public int CurrentImageNumber;
    public string[] ImageNames = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "O" };
    public void CreateField()
    {
        for (int i = 0; i < 3; i++)
        {
            cell = Instantiate(cell, new Vector3(0, 0, 0), Quaternion.identity, gameObject.transform);
            cell.transform.localPosition = new Vector3(i*95 - 95, 0, 0);
            switch (i)
            {
                case 0:
                    cell.name = "left top cell";
                    break;
                case 1:
                    cell.name = "center top cell";
                    break;
                case 2:
                    cell.name = "right top cell";
                    break;
            } 
            var f = cell.GetComponent<Effects>();
            f.Bounce();
            var content = cell.GetComponent<Content>();
            content.InsertRandomSprite();
        }
    }
}
