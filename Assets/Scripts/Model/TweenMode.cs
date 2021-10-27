using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;

public class TweenMode : MonoBehaviour
{
    protected BoxCollider2D contentCollider;
    private void Awake()
    {
        contentCollider = gameObject.GetComponent<BoxCollider2D>();
    }
    public IEnumerator DoUnclicableCoroutine(Func<Tweener> DOUncicable)
    {
        contentCollider.enabled = false;
        yield return DOUncicable().WaitForCompletion();
        contentCollider.enabled = true;
    }
    public void DoUnclicable(Func<Tweener> DOUncicable)
    {
        StartCoroutine(
            DoUnclicableCoroutine(DOUncicable));
    }
}
