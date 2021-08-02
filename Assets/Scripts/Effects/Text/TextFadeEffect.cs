using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Core;

public abstract class TextFadeEffect : MonoBehaviour
{
    public Text TextComponent { get; protected set; }
    private void Start()
    {
        TextComponent = gameObject.GetComponent<Text>();
    }
    public TweenerCore<Color, Color, DG.Tweening.Plugins.Options.ColorOptions> Fade(float alfa)
    {
        return TextComponent.DOFade(alfa, 0.2f);
    }
}
