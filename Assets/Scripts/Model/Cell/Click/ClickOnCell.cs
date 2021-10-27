using UnityEngine;
/// <summary>
///  Класс для проверки соответствия изображения на клетке заданию
/// </summary>
public class ClickOnCell : MonoBehaviour
{
    [SerializeField]
    private Task task;
    [SerializeField]
    private CorrectClick correctClick;
    [SerializeField]
    private IncorrectClick incorrectClick;
    [SerializeField]
    private CellData cellData;
    private void Start()
    {
        task = transform.root.GetComponent<Task>();
        cellData = gameObject.GetComponent<CellData>();
        correctClick = gameObject.GetComponent<CorrectClick>();
        incorrectClick = gameObject.GetComponent<IncorrectClick>();
    }
    public void CheckAnswer()
    {
        if (cellData.Number == task.CorrectCellNumber)
        {
            correctClick.DoActions();
        }
        else
        {
            incorrectClick.DoAction.Invoke();
        }
    }
}
