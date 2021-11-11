using UnityEngine;

public class ButtonFeedback : MonoBehaviour
{
    [SerializeField] protected ScaleChanger scaleChanger;
    void OnMouseDown() => scaleChanger.ChangeScale(1.1f);
    void OnMouseUp() => scaleChanger.ChangeScale(1.0f);
}
