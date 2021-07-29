using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ImageEffects : MonoBehaviour
{
    public Image image;
    public void FadeOut()
    {
        image.DOFade(1f, 0.3f);
    }
}
