using DG.Tweening;
using UnityEngine;
public class PositionPuncher : MonoBehaviour
{
    public virtual Tweener PunchPosition(float endValue)
    {
        return transform.DOPunchPosition(new Vector3(endValue, 0, 0), 0.8f, 8, 0.5f);
    }
}
