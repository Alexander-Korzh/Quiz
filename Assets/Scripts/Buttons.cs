using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class Buttons : MonoBehaviour
{
    public UnityEvent click;
    void OnMouseDown()
    {
        transform.DOScale(new Vector3(1.1f, 1.1f, 1.1f), 0.3f);
        click.Invoke();
    }
    void OnMouseUp()
    {
        transform.DOScale(new Vector3(1.0f, 1.0f, 1.0f), 0.3f);
    }
}
