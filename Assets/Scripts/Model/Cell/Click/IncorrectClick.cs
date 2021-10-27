using System;
using UnityEngine;

public class IncorrectClick : Content
{
    [SerializeField]
    public Action DoAction;
    private void Start()
    {
        DoAction = () =>
            content
                .GetComponent<EasyInBounce>()
                .DoEffect();
    }
}
