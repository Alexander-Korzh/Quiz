public class IncorrectClick : Content
{
    public void DoActions()
    {
        content
            .GetComponent<EasyInBounce>()
            .DoEffect();
    }
}
