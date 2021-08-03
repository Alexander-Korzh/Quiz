using UnityEngine;
using DG.Tweening;

public class BounceEffect : MonoBehaviour
{
    public Tweener DoBounce()
    {
        transform.DORewind();
        return transform.DOPunchScale(new Vector3(0.1f, 0.1f, 0.1f), .25f);
    }
}
