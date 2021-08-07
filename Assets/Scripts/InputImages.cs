using System.Collections.Generic;
using UnityEngine;
/// <summary>
///  Класс для работы с входными данными
/// </summary>
public class InputImages : MonoBehaviour
{
    public List<Sprite> firstInputSpriteList;
    public List<Sprite> secondInputSpriteList;
    private List<List<Sprite>> inputLists = new List<List<Sprite>>();
    private List<Sprite> imageList;
    void StartSettings()
    {
        inputLists.Add( firstInputSpriteList );
        inputLists.Add( secondInputSpriteList );
    }
    public void Initialize()
    {
        StartSettings();
        var randomIndex = Random.Range(0, inputLists.Count);
        imageList = inputLists[randomIndex];
    }
    public List<Sprite> GetList()
    {
        return imageList;
    }
    public int GetListLength()
    {
        return imageList.Count;
    }
    public Sprite GetImage(int indexInArray)
    {
        return imageList[indexInArray];
    }
    public string GetImageName(int indexInList)
    {
        return imageList[indexInList].name;
    }
}
