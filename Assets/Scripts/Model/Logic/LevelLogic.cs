// Author: Alexander Kozhikhov - https://github.com/Alexander-Korzh

using DG.Tweening;
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
    public Task task { get; private set; }
    public Field field { get; private set; }
    public InputImages inputImages { get; private set; }
    public RandomNumbers randomNumbers { get; private set; }
    public DelegateConstructor delegateConstructor { get; private set; }
    public Func<float, Tweener> fade { get; private set; }
    public Action<GameObject> firstLevelAction { get; private set; }
    public Func<bool> CorrectAnswerAction { get; private set; }

    private void Start()
    {
        task = gameObject.GetComponent<Task>();
        field = gameObject.GetComponent<Field>();
        inputImages = gameObject.GetComponent<InputImages>();
        randomNumbers = gameObject.GetComponent<RandomNumbers>();
        delegateConstructor = gameObject.GetComponent<DelegateConstructor>();
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
}