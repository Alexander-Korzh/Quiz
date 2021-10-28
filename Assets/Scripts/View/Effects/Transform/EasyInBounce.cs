public class EasyInBounce : PositionPuncher
{
    protected TweenMode tweenMode;
    private void Awake()
    {
        tweenMode = gameObject.GetComponent<TweenMode>();
    }
    public void DoEffect()
    {
        tweenMode.DoUnclicable ( 
            () => PunchPosition(0.3f));
    }
}
