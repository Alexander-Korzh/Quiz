using UnityEngine;

public class IncorrectClick : MonoBehaviour
{
    [SerializeField]
    private EaseInBounceEffect contentEaseInBounceEffect;
    private void Start()
    {
        var content = transform.GetChild(1);
        contentEaseInBounceEffect = content.GetComponent<EaseInBounceEffect>();
    }
    public void DoActions()
    {
        contentEaseInBounceEffect.DoEaseInBounce();
        Debug.Log("Неправильно");
    }
}
