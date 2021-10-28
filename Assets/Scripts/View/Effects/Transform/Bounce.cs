public class Bounce : ScalePuncher
{
    protected TweenMode tweenMode;
    private void Awake()
    {
        tweenMode = gameObject.GetComponent<TweenMode>();
    }
    public void DoEffect()
    {
        tweenMode.DoUnclicable(
            () => PunchScale(0.1f));
    }
}
