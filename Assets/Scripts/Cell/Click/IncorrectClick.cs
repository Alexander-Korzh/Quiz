using UnityEngine;

public class IncorrectClick : MonoBehaviour
{
    public EaseInBounceEffect contentEaseInBounceEffect;
    public void ActionsIfIncorrect()
    {
        contentEaseInBounceEffect.Create();
        Debug.Log("Неправильно");
    }
}
