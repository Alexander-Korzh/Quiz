using DG.Tweening;
using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    public Tweener ChangeScale(float endValue)
    {
        return transform.DOScale(new Vector3(endValue, endValue, endValue), 0.3f);
    }
}
