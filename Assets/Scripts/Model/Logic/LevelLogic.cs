// Author: Alexander Kozhikhov - https://github.com/Alexander-Korzh

using System.Collections;
using UnityEngine;

/// <summary>
///  Класс для управления общей игровой логикой уровней
/// </summary>
public class LevelLogic : MonoBehaviour
{
    public int Level { get; private set; } = 0;

    #region Fields 

    public const int CellsInLineCount = 3; 
    public const int MaxLevel = 3;
    public const int MaxCellsCount = MaxLevel * CellsInLineCount;

    public float timeLeft = 60;

    [SerializeField] private float speed;
    [SerializeField] private TaskField taskField;
    [SerializeField] private Task task;
    [SerializeField] private Field field;
    [SerializeField] private InputImages inputImages;
    [SerializeField] private RestartLogic restartLogic;
    [SerializeField] private RandomNumbers randomNumbers;
    [SerializeField] private DelegateConstructor delegateConstructor;

    #endregion

    #region Methods

    private void Start() => speed = 1;
    public void Update()
    {
        timeLeft -= speed * Time.deltaTime;

        if ( timeLeft < 0 ) restartLogic.Restart();
    }
    public int GetCellsCount() => Level * CellsInLineCount;
    public void ResetLevel() => Level = 0;
    public void NextLevel() => StartCoroutine(NextLevelCoroutine());
    public IEnumerator NextLevelCoroutine()
    {
        ++Level;

        randomNumbers.CreateList(
            inputImages.GetListLength());

        task.Create();

        yield return new WaitUntil(
            delegateConstructor.сorrectAnswerAction);

        yield return StartCoroutine(
            field.Create<CellConstructor>(
                delegateConstructor.firstLevelAction)); 

        yield return StartCoroutine(
            taskField.ChangeTaskField(
                delegateConstructor.fade)); 
    }

    #endregion
}