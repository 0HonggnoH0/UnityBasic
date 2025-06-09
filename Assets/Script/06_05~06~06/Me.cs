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
        Debug.Log($"저의 이름은 {name}입니다.");
        Debug.Log($"저의 나이는 {age}입니다.");
        Debug.Log($"저의 성별은 {gender}입니다.");
        Debug.Log($"저의 MBTI는 {mbti}입니다.");
        Debug.Log($"저의 주소는 {address}입니다.");
        Debug.Log($"저의 최애게임은 {likeGame}입니다.");
        Debug.Log($"저의 번호는 {phoneNumber}입니다.");
        Debug.Log($"저의 취미는 {hobby}입니다.");
        Debug.Log($"저의 눈시력은 {eyesight}입니다.");
        Debug.Log($"저의 국적은 {nationality}입니다.");
    }
}
