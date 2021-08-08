using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class RestartLogic : MonoBehaviour
{
    public const float DelayBeforeRestart = 0.5f;
    protected NewGameLogic newGameLogic;
    public UnityEvent restart;
    private void Start()
    {
        newGameLogic = gameObject.GetComponent<NewGameLogic>();
    }
    private IEnumerator RestartCoroutine(float delayInSeconds)
    {
        yield return newGameLogic.SmoothStartCoroutine();
        restart.Invoke();
    }
    public void Restart(float delayInSeconds)
    {
        StartCoroutine(RestartCoroutine(delayInSeconds));
    }
}