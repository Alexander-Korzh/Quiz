using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Core;

public class TextFadeEffect : MonoBehaviour
{
    protected Text textComponent;
    private void Start()
    {
        textComponent = gameObject.GetComponent<Text>();
    }
    public TweenerCore<Color, Color, DG.Tweening.Plugins.Options.ColorOptions> Fade(float alfa)
    {
        return textComponent.DOFade(alfa, 0.2f);
    }
}