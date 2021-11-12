using UnityEngine;
using UnityEngine.Events;

public class RestartLogic : MonoBehaviour
{
    public UnityEvent restart;

    #region Fields

    public static bool IsRestart;

    [SerializeField] protected NewGameLogic newGameLogic;

    #endregion

    #region Methods

    private void Start() => newGameLogic = gameObject.GetComponent<NewGameLogic>();
    public void IsEnd() => IsRestart = false;
    public void Restart()
    {
        IsRestart = true;

        newGameLogic.SmoothStart();

        System.GC.Collect();

        restart.Invoke();
    }

    #endregion
}