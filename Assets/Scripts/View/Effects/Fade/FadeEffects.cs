using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
/// <summary>
///  ����� ��� ������ � ��������� ������������ ����� DOTween
/// </summary>
public class FadeEffects : MonoBehaviour
{
    public Tweener ChangeAlfa(float alfa)
    {
        return gameObject
            .GetComponent<MaskableGraphic>()
            .DOFade(alfa, 0.3f);
    }
}
