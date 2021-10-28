// Author: Alexander Kozhikhov - https://github.com/Alexander-Korzh

using System;
using System.Collections;
using UnityEngine;

/// <summary>
///  Класс для управления общей игровой логикой уровней
/// </summary>
public class LevelLogic : MonoBehaviour
{
    public const int CellsInLineCount = 3; 
    public const int MaxLevel = 3;
    public const int MaxCellsCount = MaxLevel * CellsInLineCount;
    public int Level { get; private set; } = 0;
    public TaskField taskField;
    private Task task;
    private Field field;
    private InputImages inputImages;
    private FadeEffects textFadeEffect;
    private RandomNumbers randomNumbers;
    private ParticleSystem anyStarParticleSystem;
    private Action<GameObject> firstLevelAction;

    private void Start()
    {
        task = gameObject.GetComponent<Task>();
        field = gameObject.GetComponent<Field>();
        inputImages = gameObject.GetComponent<InputImages>();
        textFadeEffect = taskField.GetComponent<FadeEffects>();
        randomNumbers = gameObject.GetComponent<RandomNumbers>();
        anyStarParticleSystem = gameObject.GetComponentInChildren<ParticleSystem>();
        firstLevelAction = (cell) =>
           cell.GetComponent<ScalePuncher>()
               .PunchScale(0.3f); //Разобраться с инкапсуляцией;
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
            () => anyStarParticleSystem.isStopped);
        yield return StartCoroutine(
            field.Create<CellConstructor>(
                firstLevelAction)); //Разобраться, читаемо это, или нет;
        yield return StartCoroutine(
            taskField.ChangeTaskField(
                (float alfa) => textFadeEffect.ChangeAlfa(alfa))); //Разобраться с инкапсуляцией;
    }
}