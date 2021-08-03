using UnityEngine;
/// <summary>
///  Класс для проверки соответствия изображения на клетке заданию
/// </summary>
public class ClickOnCell : MonoBehaviour
{
    [SerializeField]
    private Task task;
    [SerializeField]
    private CellConstructor cellConstructor;
    [SerializeField]
    private CorrectClick correctClick;
    [SerializeField]
    private IncorrectClick incorrectClick;
    private void Start()
    {
        task = transform.root.GetComponent<Task>();
        cellConstructor = gameObject.GetComponent<CellConstructor>();
        correctClick = gameObject.GetComponent<CorrectClick>();
        incorrectClick = gameObject.GetComponent<IncorrectClick>();
    }
    public void CheckAnswer()
    {
        if (cellConstructor.GetCellNumber() == task.GetCorrectCellNumber())
        {
            correctClick.DoActions();
        }
        else
        {
            incorrectClick.DoActions();
        }
    }
}
