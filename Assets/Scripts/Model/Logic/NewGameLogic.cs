using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class NewGameLogic : MonoBehaviour
{
    public TaskField taskField;
    [SerializeField]
    private Field field;
    [SerializeField]
    private Text taskFieldTextComponent;
    [SerializeField]
    private InputImages inputImages;
    [SerializeField]
    private Task task;
    [SerializeField]
    private LevelLogic logic;
    private void Start()
    {
        task = gameObject.GetComponent<Task>();
        field = gameObject.GetComponent<Field>();
        logic = gameObject.GetComponent<LevelLogic>();
        inputImages = gameObject.GetComponent<InputImages>();
        taskFieldTextComponent = taskField.GetComponent<Text>();
        SmoothStart();
    }
    public void SmoothStart()
    {
        logic.ResetLevel();
        field.Destroy();
        inputImages.Initialize();
        task.ClearPreviousTaskNumbers();
        taskFieldTextComponent.color = new Color(1, 1, 1, 0);
    }
}
