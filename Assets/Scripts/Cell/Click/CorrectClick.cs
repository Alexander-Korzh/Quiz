using DG.Tweening;
using System.Collections;
using UnityEngine;

public class CorrectClick : MonoBehaviour
{
    [SerializeField]
    private LevelLogic logic;
    [SerializeField]
    private Stars stars;
    [SerializeField]
    private RestartLogic restartLogic;
    [SerializeField]
    private BounceEffect contentBounceEffect;
    private void Start()
    {
        logic = transform.root.GetComponent<LevelLogic>();
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
        yield return contentBounceEffect.DoBounce().WaitForCompletion();
        DOTween.PauseAll();
        CheckMaxLevel();
        Debug.Log("Правильно !!!!!");
    }
    public void CheckMaxLevel()
    {
        if (logic.GetLevel() == LevelLogic.MaxLevel)
        {
            restartLogic.Restart(RestartLogic.DelayBeforeRestart);
        }
        else
        {
            stars.Push();
            logic.NextLevel();
        }    
    }
}
