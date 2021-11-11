using UnityEngine;
using UnityEngine.Events;

public class Buttons : MonoBehaviour
{
    public UnityEvent MouseDown;
    protected virtual void OnMouseDown() => MouseDown.Invoke();
}
