using DG.Tweening;
using System;
using UnityEngine;
/// <summary>
///  Êëàññ äëÿ õğàíåíèÿ äåëåãàòîâ;
/// </summary>
public class DelegateConstructor : MonoBehaviour
{
    public FadeEffects taskFieldFade;
    public Func<float, Tweener> fade { get; private set; }
    public Action<GameObject> firstLevelAction { get; private set; }
    public Func<bool> ñorrectAnswerAction { get; private set; }

    void Start()
    {
        fade = (float alfa) =>
            taskFieldFade.ChangeAlfa(alfa);
        firstLevelAction = (cell) =>
           cell.GetComponent<ScalePuncher>()
               .PunchScale(0.3f);
        ñorrectAnswerAction = () => 
            gameObject.GetComponentInChildren<ParticleSystem>()
                        .isStopped;
    }
}
