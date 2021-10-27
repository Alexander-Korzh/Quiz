using System.Collections;
using UnityEngine;

/// <summary>
///   ласс дл€ управлени€ общей игровой логикой уровней
/// </summary>
public class LevelLogic : MonoBehaviour
{
    public const int CellsInLineCount = 3; 
    public const int MaxLevel = 3;
    public const int MaxCellsCount = MaxLevel * CellsInLineCount;
    [SerializeField]
    public int Level { get; private set; } = 0;
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
    public void ResetLevel()
    {
        Level = 0;
    }
    public int GetCellsCount()
    {
        return Level * CellsInLineCount;
    }
    public void NextLevel()
    {
        StartCoroutine(NextLevelCoroutine());
    }
    public IEnumerator NextLevelCoroutine()
    {
        ++Level;
        randomNumbers.CreateList(
            inputImages.GetListLength());
        task.Create();
        yield return new WaitUntil(() => anyStarParticleSystem.isStopped);
        yield return StartCoroutine(field.Create());
        yield return StartCoroutine(taskField.ChangeTaskField()); 
    }
}