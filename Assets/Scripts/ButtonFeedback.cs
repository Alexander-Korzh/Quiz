using UnityEngine;
using DG.Tweening;

public class ButtonFeedback : MonoBehaviour
{
    void OnMouseDown()
    {
        transform.DOScale(new Vector3(1.1f, 1.1f, 1.1f), 0.3f);
    }
    void OnMouseUp()
    {
        transform.DOScale(new Vector3(1.0f, 1.0f, 1.0f), 0.3f);
    }
}
