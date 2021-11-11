using UnityEngine;
using UnityEngine.UI;

public class ÑountdownSlider : MonoBehaviour
{
    #region Fields

    public Slider timeLeftSlider;

    [SerializeField] private LevelLogic levelLogic;

    #endregion

    private void Update() => timeLeftSlider.value = levelLogic.timeLeft;
}
