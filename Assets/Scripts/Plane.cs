using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Plane : MonoBehaviour
{
    public Image plane;
    public void FadeOut()
    {
        plane.DOFade(1f, 0.3f);
    }
}
