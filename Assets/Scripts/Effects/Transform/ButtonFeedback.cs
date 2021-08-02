using UnityEngine;
using DG.Tweening;

public class ButtonFeedback : TransformEffects
{
    void OnMouseDown()
    {
        ChangeScale(1.1f);
    }
    void OnMouseUp()
    {
        ChangeScale(1.0f);
    }
}
