using UnityEngine;
using UnityEngine.Events;

public class Buttons : MonoBehaviour
{
    public UnityEvent MouseDown;
    public UnityEvent MouseUp;
    void OnMouseDown()
    {
        MouseDown.Invoke();
    }
    void OnMouseUp()
    {
        MouseUp.Invoke();
    }
}
