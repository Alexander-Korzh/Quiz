using DG.Tweening;
using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
///  Класс для работы с текстовым полем задания
/// </summary>
public class TaskField : FadeEffects
{
    [SerializeField]
    public Task task;
    [SerializeField]
    public InputImages inputImages;
    [SerializeField]
    private StringBuilder taskTextBuilder = new StringBuilder("Find ", 10);
    protected Text textComponent;
    private void Start()
    {
        textComponent = gameObject.GetComponent<Text>();
    }
    public IEnumerator ChangeTaskField()
    {
        yield return ChangeAlfa(0).WaitForCompletion();
        textComponent.text = ShangeText();
        yield return ChangeAlfa(1).WaitForCompletion();
    }
    public string ShangeText()
    {
        if (taskTextBuilder.Length > 5)
            taskTextBuilder.Remove(5, taskTextBuilder.Length - 5);
        int taskNumber = task.TaskNumber;
        string imageName = inputImages.GetImageName(taskNumber);
        taskTextBuilder.Append(imageName);
        return taskTextBuilder.ToString();
    }
}
