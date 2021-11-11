using UnityEngine;

public class Bounce : ScalePuncher
{
    [SerializeField] protected TweenMode tweenMode;

    public void DoEffect()
    {
        tweenMode.DoUnclicable(
            () => PunchScale(0.1f));
    }
}
