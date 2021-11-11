using UnityEngine;

public class IncorrectClick : MonoBehaviour
{
    [SerializeField] private EasyInBounce contentEasyInBounce;
    public void DoActions() => contentEasyInBounce.DoEffect();
}
