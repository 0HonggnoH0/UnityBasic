using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    string star;

    void Start()
    {
        
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;

        // 페이즈 1
        for (int i = 1; i <= 5; i++)//줄 번호
        {
            for (int k = 0; k < i; k++)//별 개수
            {
                star += "★";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // 페이즈 2
        for (int i = 1; i <= 5; i++) //줄 번호
        {
            for (int j = 1; j < i; j++)// 스페이스바 횟수
            {
                star += "　";
            }

            for (int k = 5; k >= i; k--) //별 개수
            {
                star += "★";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // 페이즈 3
        for (int i = 1; i <= 5; i++)//줄 번호
        {
            for (int k = 0; k < i; k++)//별 개수
            {
                star += "★";
            }

            star += "\n";
        }

        //

        for (int i = 1; i <= 4; i++) //줄 번호
        {
            
            for (int k = 4; k >= i; k--) //별 개수
            {
                star += "★";
            }

            for (int j = 1; j < i; j++)// 스페이스바 횟수
            {
                star += "　";
            }
            star += "\n";
        }


        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // 페이즈 4
        for (int i = 1; i <= 4; i++) //줄 번호
        {
            for (int j = 4; j >= i; j--)// 스페이스바 횟수
            {
                star += "　";
            }

            for (int k = 1; k <= i; k++) //별 개수
            {
                star += "★";
            }
            star += "\n";
        }


        for (int i = 1; i <= 5; i++) //줄 번호
        {
            for (int j = 1; j < i; j++)// 스페이스바 횟수
            {
                star += "　";
            }

            for (int k = 5; k >= i; k--) //별 개수
            {
                star += "★";
            }
            star += "\n";
        }


        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // 페이즈 5
        for (int i = 1; i <= 5; i++) //줄 번호
        {
            for (int j = 4; j >= i; j--)// 왼쪽 스페이스바 횟수
            {
                star += "　";
            }

            if (i == 1)
            {
                for (int k = 1; k <= i; k++) //별 개수
                {
                    star += "★";
                }
            }

            else
            {
                for (int k = 1; k <= i+i-1; k++) //별 개수
                {
                    star += "★";
                }

            }

            for (int j = 4; j >= i; j--)// 오른쪽 스페이스바 횟수
            {
                star += "　";
            }

            star += "\n";
        }

        for (int i = 4; i >= 1; i--) //줄 번호
        {
            for (int j = 4; j >= i; j--)// 왼쪽 스페이스바 횟수
            {
                star += "　";
            }

            if (i == 1)
            {
                for (int k = 1; k <= i; k++) //별 개수
                {
                    star += "★";
                }
            }

            else
            {
                for (int k = 1; k <= i + i - 1; k++) //별 개수
                {
                    star += "★";
                }

            }

            for (int j = 4; j >= i; j--)// 오른쪽 스페이스바 횟수
            {
                star += "　";
            }

            star += "\n";
        }


        Debug.Log(star);
    }
}
