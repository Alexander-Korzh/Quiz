using DG.Tweening;
using System.Collections;
using UnityEngine;

public class CorrectClick : MonoBehaviour
{
    private Logic logic;
    private Stars stars;
    public BounceEffect contentBounceEffect;
    void Start()
    {
        logic = transform.root.GetComponent<Logic>();
        stars = transform.root.GetComponent<Stars>();
    }
    public void StartActions()
    {
        StartCoroutine(StartActionsCoroutine());
        Debug.Log("Правильно !!!!!");
    }
    public IEnumerator StartActionsCoroutine()
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
            logic.RestartWithDelay(0.5f);
        }
        else
            logic.NextLevel();
    }
}
