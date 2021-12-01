using UnityEngine;
using UnityEngine.UI;

public class LevelField : MonoBehaviour
{
    [SerializeField] private Text textField;
    [SerializeField] private LevelLogic levelLogic;

    public void ChangelevelText() => textField.text = levelLogic.Level.ToString();
}
