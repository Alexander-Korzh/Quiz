using UnityEngine;

public class ButtonFeedback : ScaleChanger
{
    //protected ScaleChanger scaleChanger;
    //private void Awake()
    //{
    //    scaleChanger = gameObject.GetComponent<ScaleChanger>();
    //} 
    void OnMouseDown()
    {
        ChangeScale(1.1f);
    }
    void OnMouseUp()
    {
        ChangeScale(1.0f);
    }
}
