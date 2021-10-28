using UnityEngine;
using UnityEngine.Events;

public class RestartLogic : MonoBehaviour
{
    public UnityEvent restart;
    protected NewGameLogic newGameLogic;
    private void Start()
    {
        newGameLogic = gameObject.GetComponent<NewGameLogic>();
    }
    public void Restart()
    {
        newGameLogic.SmoothStart();
        System.GC.Collect();
        restart.Invoke();
    }
}