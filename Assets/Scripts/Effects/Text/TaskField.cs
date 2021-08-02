using DG.Tweening;
using System.Collections;

public class TaskField : TextFadeEffect
{
    public IEnumerator ChangeText()
    {
        yield return Fade(0).WaitForCompletion();
        TextComponent.text = Task.TaskText;
        yield return Fade(1).WaitForCompletion();
    }
}
