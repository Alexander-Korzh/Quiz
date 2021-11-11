using UnityEngine;


/// <summary>
///  Класс для проверки соответствия изображения на клетке заданию
/// </summary>
public class ClickOnCell : MonoBehaviour
{
    #region Fields

    [SerializeField] private Task task;
    [SerializeField] private CorrectClick correctClick;
    [SerializeField] private IncorrectClick incorrectClick;
    [SerializeField] private CellData cellData;

    #endregion

    #region Methods

    private void Start() => task = transform.root.GetComponent<Task>();
    public void CheckAnswer()
    {
        if (cellData.Number == task.CorrectCellNumber)
        {
            correctClick.DoActions();
        }
        else
        {
            incorrectClick.DoActions();
        }
    }

    #endregion
}
