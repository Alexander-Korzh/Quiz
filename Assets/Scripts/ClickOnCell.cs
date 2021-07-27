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
        if (imageInCell.ImageNumber == Quest.TaskNumber)
        {
            StartCoroutine(CorrectAnswerEffects());
            stars.Push();
            Debug.Log("Правильно !!!!!");
        }
        else
        {
            contentEaseInBounceEffect.Create();
            Debug.Log("Неправильно");
        }
    }
    public IEnumerator CorrectAnswerEffects()
    {
        contentBounceEffect.Create();
        yield return contentBounceEffect.Create().WaitForCompletion();
        logic.NextLevel();
    }
}
