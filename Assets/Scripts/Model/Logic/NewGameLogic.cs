using UnityEngine;

public class NewGameLogic : MonoBehaviour
{
    #region Fields

    [SerializeField] private LevelLogic logic;
    [SerializeField] private Field field;
    [SerializeField] private InputImages inputImages;
    [SerializeField] private Task task;
    [SerializeField] private DelegateConstructor delegateConstructor;

    #endregion

    #region Methods

    private void Start() => SmoothStart();
    public void SmoothStart()
    {
        logic.ResetLevel();

        field.Destroy();

        inputImages.Initialize();

        task.ClearPreviousTaskNumbers();

        delegateConstructor
             .fade
             .Invoke(0);
    }

    #endregion
}
