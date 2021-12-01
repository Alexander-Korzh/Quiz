using DG.Tweening;
using System;
using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
///  Class for working with a task text field
/// </summary>

public class TaskField : MonoBehaviour
{
    #region Fields

    public Task task;
    public InputImages inputImages;

    [SerializeField] private StringBuilder taskTextBuilder = new StringBuilder("Find ", 10);
    [SerializeField] protected Text textComponent;

    #endregion

    #region Methods

    public IEnumerator ChangeTaskField(Func<float,Tweener> fade)
    {
        if (LevelLogic.playMode) LevelLogic.playMode = false;

        yield return fade(0).WaitForCompletion();

        textComponent.text = ShangeText();

        yield return fade(1).WaitForCompletion();

        LevelLogic.playMode = true;
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

    #endregion
}
