using DG.Tweening;
using System.Collections;
using UnityEngine;

public class CorrectClick : MonoBehaviour
{
    [SerializeField]
    private Logic logic;
    [SerializeField]
    private Stars stars;
    [SerializeField]
    private RestartLogic restartLogic;
    [SerializeField]
    private BounceEffect contentBounceEffect;
    private void Start()
    {
        logic = transform.root.GetComponent<Logic>();
        stars = transform.root.GetComponent<Stars>();
        restartLogic = transform.root.GetComponent<RestartLogic>();
        contentBounceEffect = transform.GetChild(1).GetComponent<BounceEffect>();
    }
    public void DoActions()
    {
        StartCoroutine(DoActionsCoroutine());
        Debug.Log("Правильно !!!!!");
    }
    protected IEnumerator DoActionsCoroutine()
    {
        contentBounceEffect.DoBounce();
        stars.Push();
        yield return contentBounceEffect.DoBounce().WaitForCompletion();
        DOTween.PauseAll();
        CheckMaxLevel();
    }
    public void CheckMaxLevel()
    {
        if (Logic.GetLevel() == Logic.MaxLevel)
        {
            restartLogic.RestartWithDelay(RestartLogic.DelayBeforeRestart);
        }
        else
            logic.NextLevel();
    }
}
