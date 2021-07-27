using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Core;

public class TextEffects : MonoBehaviour
{
    public Text gameObjectWithText;
    public IEnumerator ChangeText()
    {
        yield return Fade(0).WaitForCompletion();
        gameObjectWithText.text = Quest.task;
        yield return Fade(1).WaitForCompletion();
    }
    public TweenerCore<Color, Color, DG.Tweening.Plugins.Options.ColorOptions> Fade(float alfa)
    {
        return gameObjectWithText.DOFade(alfa, 0.2f);
    }
}
