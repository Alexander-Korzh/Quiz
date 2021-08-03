using UnityEngine;

public class ClickOnCell : MonoBehaviour
{
    [SerializeField]
    private CellConstructor cellConstructor;
    [SerializeField]
    private CorrectClick correctClick;
    [SerializeField]
    private IncorrectClick incorrectClick;
    private void Start()
    {
        cellConstructor = gameObject.GetComponent<CellConstructor>();
        correctClick = gameObject.GetComponent<CorrectClick>();
        incorrectClick = gameObject.GetComponent<IncorrectClick>();
    }
    public void CheckAnswer()
    {
        if (cellConstructor.GetCellNumber() == Task.GetCorrectCellNumber())
        {
            correctClick.DoActions();
        }
        else
        {
            incorrectClick.DoActions();
        }
    }
}
