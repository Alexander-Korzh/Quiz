using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Core;

public class TextEffects : MonoBehaviour
{
    public Text gameObjectWithText;
    public IEnumerator ChangeTextWithFade()
    {
        yield return Fade(0).WaitForCompletion();
        gameObjectWithText.text = Task.TaskText;
        yield return Fade(1).WaitForCompletion();
    }
    public TweenerCore<Color, Color, DG.Tweening.Plugins.Options.ColorOptions> Fade(float alfa)
    {
        return gameObjectWithText.DOFade(alfa, 0.2f);
    }
    public void FadeOut()
    {
        Fade(1);
    }
}
