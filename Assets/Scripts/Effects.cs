using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Events;

public class Effects : MonoBehaviour
{
    public UnityEvent On;
    public void Bounce()
    {
        transform.DORewind();
        transform.DOPunchScale(new Vector3(0.1f, 0.1f, 0.1f), .25f);
    }
}
