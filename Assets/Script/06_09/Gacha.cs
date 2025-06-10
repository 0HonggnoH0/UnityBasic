using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Gacha : MonoBehaviour
{
    List<string> characterList = new List<string>();
    public TextMeshProUGUI[] Textarray;

    void Start()
    {

        characterList.Add("Chicken0"); // 0번
        characterList.Add("Chicken1"); // 1번
        characterList.Add("Chicken2"); // 2번
        characterList.Add("Chicken3"); // 3번
        characterList.Add("Chicken4"); // 4번
        characterList.Add("Chicken5"); // 5번
        characterList.Add("Chicken6"); // 6번
        characterList.Add("Chicken7"); // 7번
        characterList.Add("Chicken8"); // 8번
        characterList.Add("Chicken9"); // 9번

    }

    public void Gatcha()
    {
        for (int i = 0; i < 9; i++)
        {
            Textarray[i].text = string.Empty;
        }
        
        int random = Random.Range(0, characterList.Count);
        Textarray[8].text = ($"{characterList[random]}");
    }

    public void Gatcha8()
    {
        
        for (int i = 0; i < 8; i++)
        {
            int random = Random.Range(0, characterList.Count);

            Textarray[i].text = ($"{characterList[random]} ");

        }
    }

}
