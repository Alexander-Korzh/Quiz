using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
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
    public Tweener Fade(float alfa)
    {
        return Image.DOFade(alfa, 0.3f);
    }
}
