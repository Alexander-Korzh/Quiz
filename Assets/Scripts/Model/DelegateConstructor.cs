using DG.Tweening;
using System;
using UnityEngine;


/// <summary>
///  Class for working and control delegates;
/// </summary>

public class DelegateConstructor : MonoBehaviour
{

    #region Properties

    public Func<float, Tweener> fade { get; private set; }
    public Action<GameObject> firstLevelAction { get; private set; }
    public Func<bool> ñorrectAnswerAction { get; private set; }

    #endregion

    #region Fields

    [SerializeField] private FadeEffects taskFieldFade;
    [SerializeField] private ParticleSystem stars;

    #endregion

    void Awake()
    {
        fade = (float alfa) =>
            taskFieldFade
                .ChangeAlfa(alfa);

        firstLevelAction = (cell) =>
           cell
                .GetComponent<ScalePuncher>()
                .PunchScale(0.3f);

        ñorrectAnswerAction = () => stars.isStopped;
    }
}
