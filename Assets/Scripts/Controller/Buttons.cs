using UnityEngine;
using UnityEngine.Events;

public class Buttons : MonoBehaviour
{
    public UnityEvent MouseDown;

    public  void OnMouseDown() => MouseDown.Invoke();
}
