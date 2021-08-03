using DG.Tweening;
using System.Collections;
/// <summary>
///  ����� ��� ������ � ��������� ����� �������
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
