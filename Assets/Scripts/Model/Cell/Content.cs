using UnityEngine;

public class Content : MonoBehaviour
{
    [SerializeField]
    protected Transform content;
    private void Awake() => content = transform.GetChild(1);
}
