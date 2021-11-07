using UnityEngine;

public class NewGameLogic : MonoBehaviour
{
    [SerializeField]
    private LevelLogic logic;
    [SerializeField]
    private Field field;
    [SerializeField]
    private InputImages inputImages;
    [SerializeField]
    private Task task;
    [SerializeField]
    private DelegateConstructor delegateConstructor;
    

    private void Start()
    {
        logic = gameObject.GetComponent<LevelLogic>();
        field = gameObject.GetComponent<Field>();
        inputImages = gameObject.GetComponent<InputImages>();
        task = gameObject.GetComponent<Task>();
        delegateConstructor = gameObject.GetComponent<DelegateConstructor>();
        SmoothStart();
    }
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
}
