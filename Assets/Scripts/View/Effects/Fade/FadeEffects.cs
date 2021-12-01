using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


/// <summary>
///  Class for working with transparency effects using DOTween
/// </summary>

public class FadeEffects : MonoBehaviour
{
    [SerializeField] private MaskableGraphic transparency;

    public Tweener ChangeAlfa(float alfa) => transparency.DOFade(alfa, 0.1f);
}
