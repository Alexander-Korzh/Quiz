using DG.Tweening;
using UnityEngine;

public class TransformEffects : MonoBehaviour
{
    public Tweener PunchPosition()
    {
        return transform.DOPunchPosition(new Vector3(0.3f, 0, 0), 0.8f, 8, 0.5f);
    }
    public Tweener ChangeScale(float endValue)
    {
        return transform.DOScale(new Vector3(endValue, endValue, endValue), 0.3f);
    }

}
