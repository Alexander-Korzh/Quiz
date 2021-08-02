using UnityEngine;
using DG.Tweening;
using System.Collections;

public class BounceEffect : MonoBehaviour
{
    public Tweener Create()
    {
        transform.DORewind();
        return transform.DOPunchScale(new Vector3(0.1f, 0.1f, 0.1f), .25f);
    }
}
