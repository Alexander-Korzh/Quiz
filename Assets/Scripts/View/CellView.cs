using UnityEngine;

public class CellView : MonoBehaviour
{
    private LevelLogic logic;
    private Bounce bounceEffect;
    private void Awake()
    {
        logic = gameObject.GetComponent<LevelLogic>();
        bounceEffect = gameObject.GetComponent<Bounce>();
    }
    public void ShowCell(bool value)
    {
        gameObject.SetActive(value);
        //if (logic.level == 1)
        //    bounceEffect.DoAction(0.1f);
    }
}
