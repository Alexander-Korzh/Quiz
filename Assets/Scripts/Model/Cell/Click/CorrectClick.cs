using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;

public class CorrectClick : MonoBehaviour
{
    #region Fields

    [SerializeField] private Action BounceAction;
    [SerializeField] private Bounce contentBounce;
    [SerializeField] private LevelLogic logic;
    [SerializeField] private RestartLogic restartLogic;
    [SerializeField] private Stars stars;

    #endregion

    #region Methods

    private void Start()
    {
        BounceAction = () => contentBounce.DoEffect();

        logic = transform.root.GetComponent<LevelLogic>();

        restartLogic = transform.root.GetComponent<RestartLogic>();

        stars = transform.root.GetComponent<Stars>();
    }
    public void DoActions() => StartCoroutine(DoActionsCoroutine());
    protected IEnumerator DoActionsCoroutine()
    {
        stars.Push();

        BounceAction.Invoke();

        yield return new WaitUntil(
            () => DOTween.TotalPlayingTweens() == 0);

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

    #endregion
}
