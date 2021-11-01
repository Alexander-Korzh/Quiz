using UnityEngine;
using UnityEngine.UI;

public class NewGameLogic : MonoBehaviour
{
    private LevelLogic logic;

    private void Start()
    {
        logic = gameObject.GetComponent<LevelLogic>();
        SmoothStart();
    }
    public void SmoothStart()
    {
        logic.ResetLevel();
        logic.field.Destroy();
        logic.inputImages.Initialize();
        logic.task.ClearPreviousTaskNumbers();
        logic.delegateConstructor
             .fade
             .Invoke(0);
    }
}
