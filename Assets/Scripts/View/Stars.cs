using UnityEngine;
using UnityEngine.Events;
public class Stars : MonoBehaviour
{
    public UnityEvent pushStars;
    public void Push() => pushStars.Invoke();
}
