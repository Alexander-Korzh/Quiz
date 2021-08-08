using UnityEngine;

/// <summary>
///   ласс дл€ управлени€ общей игровой логикой уровней
/// </summary>
public class LevelLogic : MonoBehaviour
{
    public const int CellsInLineCount = 3; 
    public const int MaxLevel = 3;
    [SerializeField]
    private int level = 0;
    public TaskField taskField;
    [SerializeField]
    private Field field;
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
        randomNumbers = gameObject.GetComponent<RandomNumbers>();
    }
    public int GetLevel()
    {
        return level;
    }
    public void ResetLevel()
    {
        level = 0;
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