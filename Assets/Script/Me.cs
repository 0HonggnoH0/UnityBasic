using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hong : MonoBehaviour
{
    // Start is called before the first frame update

    string name = "HSB";
    string gender = "man";
    int age = 26;
    string mbti = "ENFP-T";
    string address = "Jeju";
    string likeGame = "MapleStory";
    string phoneNumber = "01067974707";
    string hobby = "Game and watching baseball";
    string eyesight = "left 0.4 , right 0.5";
    string nationality = "South Korea";

    void Start()
    {
        SelfIntroduction();    
    }
    public void SelfIntroduction()
    {
        Debug.Log($"���� �̸��� {name}�Դϴ�.");
        Debug.Log($"���� ���̴� {age}�Դϴ�.");
        Debug.Log($"���� ������ {gender}�Դϴ�.");
        Debug.Log($"���� MBTI�� {mbti}�Դϴ�.");
        Debug.Log($"���� �ּҴ� {address}�Դϴ�.");
        Debug.Log($"���� �־ְ����� {likeGame}�Դϴ�.");
        Debug.Log($"���� ��ȣ�� {phoneNumber}�Դϴ�.");
        Debug.Log($"���� ��̴� {hobby}�Դϴ�.");
        Debug.Log($"���� ���÷��� {eyesight}�Դϴ�.");
        Debug.Log($"���� ������ {nationality}�Դϴ�.");
    }
}
