using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;

public class TweenMode : MonoBehaviour
{
    [SerializeField] protected BoxCollider2D contentCollider;

    #region Methods

    public virtual IEnumerator DoUnclicableCoroutine(Func<Tweener> DOUncicable)
    {
        contentCollider.enabled = false;

        yield return DOUncicable().WaitForCompletion();

        contentCollider.enabled = true;
    }
    public void DoUnclicable(Func<Tweener> DOUncicable) =>
        StartCoroutine(
            DoUnclicableCoroutine(DOUncicable));

    #endregion
}
