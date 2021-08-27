using System.Collections;
using UnityEngine;

/// <summary>
///  ����� ��� ���������� ����� ������� ������� �������
/// </summary>
public class LevelLogic : MonoBehaviour
{
    public const int CellsInLineCount = 3; 
    public const int MaxLevel = 3;
    public const int MaxCellsCount = MaxLevel * CellsInLineCount;
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
    [SerializeField]
    private ParticleSystem anyStarParticleSystem;

    private void Start()
    {
        task = gameObject.GetComponent<Task>();
        field = gameObject.GetComponent<Field>();
        inputImages = gameObject.GetComponent<InputImages>();
        randomNumbers = gameObject.GetComponent<RandomNumbers>();
        anyStarParticleSystem = gameObject.GetComponentInChildren<ParticleSystem>();
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
        StartCoroutine(NextLevelCoroutine());
    }
    public IEnumerator NextLevelCoroutine()
    {
        ++level;
        int inputListLength = inputImages.GetListLength();
        randomNumbers.CreateList(inputListLength);
        task.Create();
        yield return new WaitUntil(() => anyStarParticleSystem.isStopped);
        yield return StartCoroutine(field.Create());
        yield return StartCoroutine(taskField.ChangeTaskField());
    }
}