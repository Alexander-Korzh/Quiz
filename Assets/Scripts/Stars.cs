using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Stars : MonoBehaviour
{
    public UnityEvent pushStars;
    public void Push()
    {
        pushStars.Invoke();
    }
}
