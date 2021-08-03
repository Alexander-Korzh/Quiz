using DG.Tweening;
using System.Collections;
/// <summary>
///  Класс для работы с текстовым полем задания
/// </summary>
public class TaskField : TextFadeEffect
{
    public Task task;
    public IEnumerator ChangeText()
    {
        yield return Fade(0).WaitForCompletion();
        textComponent.text = task.GetTaskText();
        yield return Fade(1).WaitForCompletion();
    }
}
