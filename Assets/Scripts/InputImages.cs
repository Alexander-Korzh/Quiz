using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///  Класс для работы с входными данными
/// </summary>
public class InputImages : MonoBehaviour
{
    public const int InputListsCount = 2;
    public List<Sprite> firstInputSpriteList;
    public List<Sprite> secondInputSpriteList;
    public List<Sprite>[] inputLists = new List<Sprite>[InputListsCount];
    private List<Sprite> imageList;
    private void Start()
    {
        inputLists[0] = firstInputSpriteList;
        inputLists[1] = secondInputSpriteList;
    }
    public void Initialize()
    {
        var randomIndex = Random.Range(0, inputLists.Length);
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
