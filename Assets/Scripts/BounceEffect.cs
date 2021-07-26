using UnityEngine;
using DG.Tweening;

public class BounceEffect : MonoBehaviour
{
    public void Create()
    {
        transform.DORewind();
        transform.DOPunchScale(new Vector3(0.2f, 0.2f, 0.2f), .25f);
    }
}
