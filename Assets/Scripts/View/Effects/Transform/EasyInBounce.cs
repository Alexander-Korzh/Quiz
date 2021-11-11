using UnityEngine;

public class EasyInBounce : PositionPuncher
{
    [SerializeField] protected TweenMode tweenMode;

    public void DoEffect()
    {
        tweenMode.DoUnclicable ( 
            () => PunchPosition(0.3f));
    }
}
