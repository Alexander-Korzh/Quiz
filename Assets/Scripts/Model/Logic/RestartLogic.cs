using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class RestartLogic : MonoBehaviour
{
    protected NewGameLogic newGameLogic;
    public UnityEvent restart;
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