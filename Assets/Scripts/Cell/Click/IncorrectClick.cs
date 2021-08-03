using UnityEngine;

public class IncorrectClick : MonoBehaviour
{
    [SerializeField]
    private EaseInBounceEffect contentEaseInBounceEffect;
    private void Start()
    {
        contentEaseInBounceEffect = transform.GetChild(1).GetComponent<EaseInBounceEffect>();
    }
    public void DoActions()
    {
        contentEaseInBounceEffect.DoEaseInBounce();
        Debug.Log("Неправильно");
    }
}
