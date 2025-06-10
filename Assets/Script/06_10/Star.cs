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

        // ������ 1
        for (int i = 1; i <= 5; i++)//�� ��ȣ
        {
            for (int k = 0; k < i; k++)//�� ����
            {
                star += "��";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // ������ 2
        for (int i = 1; i <= 5; i++) //�� ��ȣ
        {
            for (int j = 1; j < i; j++)// �����̽��� Ƚ��
            {
                star += "��";
            }

            for (int k = 5; k >= i; k--) //�� ����
            {
                star += "��";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // ������ 3
        for (int i = 1; i <= 5; i++)//�� ��ȣ
        {
            for (int k = 0; k < i; k++)//�� ����
            {
                star += "��";
            }

            star += "\n";
        }

        //

        for (int i = 1; i <= 4; i++) //�� ��ȣ
        {
            
            for (int k = 4; k >= i; k--) //�� ����
            {
                star += "��";
            }

            for (int j = 1; j < i; j++)// �����̽��� Ƚ��
            {
                star += "��";
            }
            star += "\n";
        }


        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // ������ 4
        for (int i = 1; i <= 4; i++) //�� ��ȣ
        {
            for (int j = 4; j >= i; j--)// �����̽��� Ƚ��
            {
                star += "��";
            }

            for (int k = 1; k <= i; k++) //�� ����
            {
                star += "��";
            }
            star += "\n";
        }


        for (int i = 1; i <= 5; i++) //�� ��ȣ
        {
            for (int j = 1; j < i; j++)// �����̽��� Ƚ��
            {
                star += "��";
            }

            for (int k = 5; k >= i; k--) //�� ����
            {
                star += "��";
            }
            star += "\n";
        }


        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // ������ 5
        for (int i = 1; i <= 5; i++) //�� ��ȣ
        {
            for (int j = 4; j >= i; j--)// ���� �����̽��� Ƚ��
            {
                star += "��";
            }

            if (i == 1)
            {
                for (int k = 1; k <= i; k++) //�� ����
                {
                    star += "��";
                }
            }

            else
            {
                for (int k = 1; k <= i+i-1; k++) //�� ����
                {
                    star += "��";
                }

            }

            for (int j = 4; j >= i; j--)// ������ �����̽��� Ƚ��
            {
                star += "��";
            }

            star += "\n";
        }

        for (int i = 4; i >= 1; i--) //�� ��ȣ
        {
            for (int j = 4; j >= i; j--)// ���� �����̽��� Ƚ��
            {
                star += "��";
            }

            if (i == 1)
            {
                for (int k = 1; k <= i; k++) //�� ����
                {
                    star += "��";
                }
            }

            else
            {
                for (int k = 1; k <= i + i - 1; k++) //�� ����
                {
                    star += "��";
                }

            }

            for (int j = 4; j >= i; j--)// ������ �����̽��� Ƚ��
            {
                star += "��";
            }

            star += "\n";
        }


        Debug.Log(star);
    }
}
