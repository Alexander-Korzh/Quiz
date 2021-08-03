using DG.Tweening;
using System.Collections;

public class TaskField : TextFadeEffect
{
    public IEnumerator ChangeText()
    {
        yield return Fade(0).WaitForCompletion();
        textComponent.text = Task.GetTaskText();
        yield return Fade(1).WaitForCompletion();
    }
}
