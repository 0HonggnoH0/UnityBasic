using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Text : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public string nextText;
    public void OnClickButton()
    {
        Text.text = nextText; 
    }
}
