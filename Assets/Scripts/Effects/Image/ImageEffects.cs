using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
/// <summary>
///  Класс для работы с эффектами изображения через DOTween
/// </summary>
public class ImageEffects : MonoBehaviour
{
    protected Image Image;
    private void Start()
    {
       Image = gameObject.GetComponent<Image>();
    }
    //public Tweener Fade(float alfa)
    //{
    //    return Image.DOFade(alfa, 0.3f);
    //}
    public Tweener Fade(float alfa)
    {
        var objectToFade = gameObject.GetComponent<MaskableGraphic>();
        return objectToFade.DOFade(alfa, 0.3f);
    }
}
