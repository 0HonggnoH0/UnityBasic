using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetHp : MonoBehaviour
{
    public Image Img_HPbar;

    public int MaxHP;
    float nowHP;
    // 최소 체력 = 0

    public int Damage;
    public int HealPoint;

    private void Awake()
    {
        nowHP = MaxHP;
    }

    public void OnClickDamage()
    {
        nowHP -= Damage;
        if(nowHP < 0)
        {
            nowHP = 0;
        }

        RefreshUI();
    }
    public void OnClickHeal()
    {
        nowHP += HealPoint;
        if(nowHP >MaxHP)
        {
            nowHP = MaxHP;
        }
        RefreshUI();
        
    }

    void RefreshUI()
    {
        Img_HPbar.fillAmount = nowHP / MaxHP;
    }
    

}
