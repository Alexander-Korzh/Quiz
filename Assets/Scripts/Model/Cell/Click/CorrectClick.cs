using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;

public class CorrectClick : Content
{
    [SerializeField]
    private LevelLogic logic;
    [SerializeField]
    private Stars stars;
    [SerializeField]
    private RestartLogic restartLogic;
    [SerializeField]
    private Action contentBounceEffect;
    private void Start()
    {
        logic = transform.root.GetComponent<LevelLogic>();
        stars = transform.root.GetComponent<Stars>();
        restartLogic = transform.root.GetComponent<RestartLogic>();
        contentBounceEffect = () => 
            content
                .GetComponent<Bounce>()
                .DoEffect();  // Уточнить, законно ли вообще так писать
    }
    public void DoActions()
    {
        StartCoroutine(DoActionsCoroutine());
        //Debug.Log("Правильно !!!!!");
    }
    protected IEnumerator DoActionsCoroutine()
    {
        stars.Push();
        contentBounceEffect.Invoke();
        yield return new WaitUntil(() => DOTween.TotalPlayingTweens() == 0);
        CheckMaxLevel();
    }
    public void CheckMaxLevel()
    {
        if (logic.Level == LevelLogic.MaxLevel)
        {
            restartLogic.Restart();
        }
        else
        {
            logic.NextLevel();
        }    
    }
}
