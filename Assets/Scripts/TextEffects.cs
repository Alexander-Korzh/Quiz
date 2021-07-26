using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using DG.Tweening;

public class TextEffects : MonoBehaviour
{
    public Text textToFade;
    public IEnumerator Appearance()
    {
        var tween1 = textToFade.DOFade(0f, 0.2f);
        yield return tween1.WaitForCompletion();
        textToFade.text = Quest.task;
        var tween = textToFade.DOFade(1f, 0.2f);
        yield return tween.WaitForCompletion();
    }
}
