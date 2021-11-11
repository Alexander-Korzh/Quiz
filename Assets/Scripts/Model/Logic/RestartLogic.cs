using UnityEngine;
using UnityEngine.Events;

public class RestartLogic : MonoBehaviour
{
    public UnityEvent restart;

    #region Fields

    [SerializeField] protected NewGameLogic newGameLogic;

    #endregion

    #region Methods

    private void Start() => newGameLogic = gameObject.GetComponent<NewGameLogic>();
    public void Restart()
    {
        newGameLogic.SmoothStart();

        System.GC.Collect();

        restart.Invoke();
    }

    #endregion
}