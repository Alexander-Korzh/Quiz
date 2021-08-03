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
    public void Restart()
    {
        logic.SmoothStart();
        restart.Invoke();
    }
    private IEnumerator RestartWithDelayCoroutine(float delayInSeconds)
    {
        yield return new WaitForSeconds(delayInSeconds);
        Restart();
    }
    public void RestartWithDelay(float delayInSeconds)
    {
        StartCoroutine(RestartWithDelayCoroutine(delayInSeconds));
    }
}