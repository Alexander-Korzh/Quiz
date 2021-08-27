using DG.Tweening;
using System.Collections;
using System.Text;
using UnityEngine;
/// <summary>
///  Класс для работы с текстовым полем задания
/// </summary>
public class TaskField : TextFadeEffect
{
    [SerializeField]
    public Task task;
    [SerializeField]
    public InputImages inputImages;
    [SerializeField]
    private StringBuilder taskTextBuilder = new StringBuilder("Find ", 10);
    public IEnumerator ChangeTaskField()
    {
        yield return Fade(0).WaitForCompletion();
        textComponent.text = ShangeText();
        yield return Fade(1).WaitForCompletion();
    }
    public string ShangeText()
    {
        if (taskTextBuilder.Length > 5)
            taskTextBuilder.Remove(5, taskTextBuilder.Length - 5);
        int taskNumber = task.taskNumber;
        string imageName = inputImages.GetImageName(taskNumber);
        taskTextBuilder.Append(imageName);
        //taskTextBuilder.Append(inputImages.GetImageName(task.taskNumber));
        return taskTextBuilder.ToString();
    }
}
