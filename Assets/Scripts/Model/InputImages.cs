using System.Collections.Generic;
using UnityEngine;


/// <summary>
///  Класс для работы с входными данными
/// </summary>
public class InputImages : MonoBehaviour
{
    //TODO Возможно правильнее заменить весь класс на ScriptableObject
    #region Fields

    public List<Sprite> firstInputSpriteList;
    public List<Sprite> secondInputSpriteList;
    private List<List<Sprite>> inputLists = new List<List<Sprite>>(2);
    private List<Sprite> imageList;

    #endregion

    #region Methods

    void StartSettings()
    {
        inputLists.Add( firstInputSpriteList );
        inputLists.Add( secondInputSpriteList );
    }
    public void Initialize()
    {
        StartSettings();

        imageList = inputLists[
            Random.Range(0, inputLists.Count)];
    }
    public List<Sprite> GetList() => imageList;
    public int GetListLength() => imageList.Count;
    public Sprite GetImage(int indexInArray) => imageList[indexInArray];
    public string GetImageName(int indexInList) => imageList[indexInList].name;

    #endregion
}
