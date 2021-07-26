using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Events;

public class Effects : MonoBehaviour
{
    public void Bounce()
    {
            transform.DORewind();
            transform.DOPunchScale(new Vector3(0.2f, 0.2f, 0.2f), .25f);
    }
    public void EaseInBounce()
    {
        transform.DOPunchPosition(new Vector3(20, 0, 0), 1, 10, 0.5f);
    }
    // the image you want to fade, assign in inspector
    public Text img;

    public IEnumerator FadeImage(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 1; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                img.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
        // fade from transparent to opaque
        else
        {
            // loop over 1 second
            for (float i = 0; i <= 1; i += Time.deltaTime)
            {
                // set color with i as alpha
                img.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
    }
}
