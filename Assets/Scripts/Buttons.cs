using UnityEngine;
using UnityEngine.Events;

public class Buttons : MonoBehaviour
{
    public UnityEvent MouseDown;
    void OnMouseDown()
    {
        MouseDown.Invoke();
    }
}
