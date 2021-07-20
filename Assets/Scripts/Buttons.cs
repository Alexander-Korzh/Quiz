using UnityEngine;
using UnityEngine.Events;

public class Buttons : MonoBehaviour
{
    public UnityEvent click;
    void OnMouseDown()
    {
        click.Invoke();
    }
}
