using DG.Tweening;
using UnityEngine;

public class ScalePuncher : MonoBehaviour
{
    public Tweener PunchScale(float endValue) => 

        transform.DOPunchScale(new Vector3(endValue, endValue, endValue), .25f);
}
