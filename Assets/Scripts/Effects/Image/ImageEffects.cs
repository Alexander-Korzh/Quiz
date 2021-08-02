using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ImageEffects : MonoBehaviour
{
    public Image Image { get; private set; }

    private void Start()
    {
       Image = gameObject.GetComponent<Image>();
    }
    public Tweener Fade(float alfa)
    {
        return Image.DOFade(alfa, 0.3f);
    }
}
