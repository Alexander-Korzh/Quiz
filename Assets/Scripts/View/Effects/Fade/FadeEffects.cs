using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


/// <summary>
///  Класс для работы с эффектами прозрачности через DOTween
/// </summary>
public class FadeEffects : MonoBehaviour
{
    [SerializeField] private MaskableGraphic transparency;

    public Tweener ChangeAlfa(float alfa) => transparency.DOFade(alfa, 0.3f);
}
