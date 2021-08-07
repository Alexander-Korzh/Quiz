using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class RestartLogic : MonoBehaviour
{
    public const float DelayBeforeRestart = 0.5f;
    protected Logic logic;
    public UnityEvent restart;
    private void Start()
    {
        logic = gameObject.GetComponent<Logic>();
    }
    private IEnumerator RestartCoroutine(float delayInSeconds)
    {
        yield return logic.SmoothStartCoroutine();
        restart.Invoke();
    }
    public void Restart(float delayInSeconds)
    {
        StartCoroutine(RestartCoroutine(delayInSeconds));
    }
}