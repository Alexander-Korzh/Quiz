using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cell : MonoBehaviour
{
    public GameObject cell;
    public List<GameObject> cells;
    public void Create()
    {
        for (int i = 0; i < 3; i++)
        {

            cell = Instantiate(cell, new Vector3(0, 0, 0), Quaternion.identity, gameObject.transform);
            cell.transform.localPosition = new Vector3(i*95 - 95, 0, 0);
            cell.transform.DORewind();
            cell.transform.DOPunchScale(new Vector3(0.1f, 0.1f, 0.1f), .25f);
        }
    }
}
