using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ClickOnCell : MonoBehaviour
{
    private CellConstructor cellConstructor;
    private CorrectClick correctClick;
    private IncorrectClick incorrectClick;
    void Start()
    {
        cellConstructor = gameObject.GetComponent<CellConstructor>();
        correctClick = gameObject.GetComponent<CorrectClick>();
        incorrectClick = gameObject.GetComponent<IncorrectClick>();
    }
    public void CheckAnswer()
    {
        if (cellConstructor.cellNumber == Task.CorrectCellNumber)
        {
            correctClick.StartActions();
        }
        else
        {
            incorrectClick.ActionsIfIncorrect();
        }
    }
}
