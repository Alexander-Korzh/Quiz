using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    public const int CellsInLineCount = 3; // ограничено классом CellPosition
    public const int MaxLevel = 3; // ограничено классом CellPosition
    public TaskField taskField;
    [SerializeField]
    private Field field;
    [SerializeField]
    private Text taskFieldTextComponent;
    private static int level  = 0;
    private void Start()
    {
        taskFieldTextComponent = taskField.GetComponent<Text>();
        field = gameObject.GetComponent<Field>();
        SmoothStart();
    }
    public void SmoothStart()
    {
        StartCoroutine(SmoothStartCoroutine());
    }
    private IEnumerator SmoothStartCoroutine()
    {
        taskFieldTextComponent.color = new Color(1, 1, 1, 0);
        field.Destroy();
        var previousTaskNumbers = Task.GetPreviousTaskNumbers();
        previousTaskNumbers.Clear();
        level = 0;
        yield return null;
    }
    public static int GetLevel()
    {
        return level;
    }
    public static int GetCellsCount()
    {
        return level * CellsInLineCount;
    }
    public void NextLevel()
    {
        level++;
        RandomNumbers.CreateList(InputData.GetInputArrayLength() - 1);
        Task.Create();
        StartCoroutine(taskField.ChangeText());
        field.Create();
    }
}