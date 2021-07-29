using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class ClickOnCell : MonoBehaviour
{
    private Logic logic;
    private Stars stars;
    public BounceEffect contentBounceEffect;
    public EaseInBounceEffect contentEaseInBounceEffect;
    public RandomSprite imageInCell;
    void Start()
    {
        logic = transform.root.GetComponent<Logic>();
        stars = transform.root.GetComponent<Stars>();
    }
    public void CheckAnswer()
    {
        if (imageInCell.ImageNumber == Task.TaskNumber)
        {
            StartCoroutine(ActionsIfCorrect());
            Debug.Log("��������� !!!!!");
        }
        else
        {
            contentEaseInBounceEffect.Create();
            Debug.Log("�����������");
        }
    }
    public IEnumerator ActionsIfCorrect()
    {
        contentBounceEffect.Create();
        stars.Push();
        yield return contentBounceEffect.Create().WaitForCompletion();
        CheckMaxLevel();
    }
    public void CheckMaxLevel()
    {
        if (Logic.Level == Logic.maxLevel)
        {
            StartCoroutine(logic.RestartWithDelay(1));
        }
        else
            logic.NextLevel();
    }
}
