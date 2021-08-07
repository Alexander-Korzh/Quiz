using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
///   ласс дл€ управлени€ общей игровой логикой уровней
/// </summary>
public class Logic : MonoBehaviour
{
    public const int CellsInLineCount = 3; 
    public const int MaxLevel = 3;
    [SerializeField]
    private int level = 0;
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
    private RandomNumbers randomNumbers;
    private void Start()
    {
        task = gameObject.GetComponent<Task>();
        field = gameObject.GetComponent<Field>();
        inputImages = gameObject.GetComponent<InputImages>();
        taskFieldTextComponent = taskField.GetComponent<Text>();
        randomNumbers = gameObject.GetComponent<RandomNumbers>();
        SmoothStart();
    }
    public void SmoothStart()
    {
        StartCoroutine(SmoothStartCoroutine());
    }
    public IEnumerator SmoothStartCoroutine()
    {
        System.GC.Collect();
        level = 0;
        taskFieldTextComponent.color = new Color(1, 1, 1, 0);
        field.Destroy();
        inputImages.Initialize();
        task.ClearPreviousTaskNumbers();
        randomNumbers.ClearList();
        yield return null;
    }
    public int GetLevel()
    {
        return level;
    }
    public int GetCellsCount()
    {
        return level * CellsInLineCount;
    }
    public void NextLevel()
    {
        level++;
        var inputListLength = inputImages.GetListLength() - 1;
        randomNumbers.CreateList(inputListLength);
        task.Create();
        StartCoroutine(taskField.ChangeText());
        StartCoroutine(field.Create());
    }
}