using System.Collections;
using UnityEngine;
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
    private RandomNumbers randomNumbers;
    [SerializeField]
    private LevelLogic logic;
    private void Start()
    {
        task = gameObject.GetComponent<Task>();
        field = gameObject.GetComponent<Field>();
        logic = gameObject.GetComponent<LevelLogic>();
        inputImages = gameObject.GetComponent<InputImages>();
        taskFieldTextComponent = taskField.GetComponent<Text>();
        randomNumbers = gameObject.GetComponent<RandomNumbers>();
        SmoothStart();
    }
    public void SmoothStart()
    {
        StartCoroutine(SmoothStartCoroutine());
    }
    public IEnumerator SmoothStartCoroutine()
    {
        logic.ResetLevel();
        field.Destroy();
        inputImages.Initialize();
        task.ClearPreviousTaskNumbers();
        taskFieldTextComponent.color = new Color(1, 1, 1, 0);
        yield return null;
    }
}
