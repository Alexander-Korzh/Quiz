using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
///  ����� ��� ���������� ����� ������� ������� �������
/// </summary>
public class Logic : MonoBehaviour
{
    public const int CellsInLineCount = 3; // ���������� ������� CellPosition
    public const int MaxLevel = 3; // ���������� ������� CellPosition
    public TaskField taskField;
    [SerializeField]
    private Field field;
    [SerializeField]
    private Text taskFieldTextComponent;
    [SerializeField]
    private InputImages inputImages;
    [SerializeField]
    private Task task;
    [SerializeField]
    private static int level  = 0;
    private void Start()
    {
        task = gameObject.GetComponent<Task>();
        field = gameObject.GetComponent<Field>();
        inputImages = gameObject.GetComponent<InputImages>();
        taskFieldTextComponent = taskField.GetComponent<Text>();
        SmoothStart();
    }
    public void SmoothStart()
    {
        StartCoroutine(SmoothStartCoroutine());
    }
    private IEnumerator SmoothStartCoroutine()
    {
        inputImages.Initialize();
        taskFieldTextComponent.color = new Color(1, 1, 1, 0);
        field.Destroy();
        var previousTaskNumbers = task.GetPreviousTaskNumbers();
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
        RandomNumbers.CreateList(inputImages.GetListLength() - 1);
        task.Create();
        StartCoroutine(taskField.ChangeText());
        StartCoroutine(field.Create());
    }
}