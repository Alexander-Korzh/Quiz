using UnityEngine;
using DG.Tweening;
using System.Collections;

public class BounceEffect : MonoBehaviour
{
    public Tweener Create()
    {
        transform.DORewind();
        return transform.DOPunchScale(new Vector3(0.3f, 0.3f, 0.3f), .25f);
    }
    public IEnumerator CreateAndWait()
    {
        Create();
        yield return Create().WaitForCompletion();
    }
}
