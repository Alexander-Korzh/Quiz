using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class ClickOnCell : MonoBehaviour
{
    private Logic logic;
    public BounceEffect contentBounceEffect;
    public EaseInBounceEffect contentEaseInBounceEffect;
    public RandomSprite imageInCell;
    private bool correctAnswerFlag;
    void Start()
    {
        logic = transform.root.GetComponent<Logic>();
    }
    public void CheckAnswer()
    {
        if (imageInCell.ImageNumber == Quest.GetTaskNumber())
        {
            correctAnswerFlag = true;
            contentBounceEffect.Create();
            Debug.Log("Правильно !!!!!");
        }
        else
        {
            contentEaseInBounceEffect.Create();
            Debug.Log("Неправильно");
        }
    }
    public void Commit()
    {
        if (correctAnswerFlag == true ) logic.NextLevel();
        correctAnswerFlag = false;
    }
}
