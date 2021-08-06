using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextFadeEffect : MonoBehaviour
{
    protected Text textComponent;
    private void Start()
    {
        textComponent = gameObject.GetComponent<Text>();
    }
    public Tweener Fade(float alfa)
    {
        return textComponent.DOFade(alfa, 0.2f);
    }
}
