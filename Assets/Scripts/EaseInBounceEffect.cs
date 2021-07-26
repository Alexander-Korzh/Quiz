using DG.Tweening;
using UnityEngine;

public class EaseInBounceEffect : MonoBehaviour
{
    public void Create()
    {
        transform.DOPunchPosition(new Vector3(20, 0, 0), 1, 10, 0.5f);
    }
}
