using DG.Tweening;
using UnityEngine;

public class ScalePuncher : MonoBehaviour
{
    public Tweener PunchScale(float endValue)
    {
        return transform.DOPunchScale(new Vector3(endValue, endValue, endValue), .25f);
    }
}
