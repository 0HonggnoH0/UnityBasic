using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{

    int count;

    private void Awake()
    {
        count = 0;
    }

    void Start()
    {
    }


    public void Gacha()
    {
        //Ȯ���� 10% -> �α� : '��û'�� ����!

        //Ȯ���� 20% -> �α� : '��'�� ����!

        //Ȯ���� 70% -> �α� : 'ġġ'�� ����!

       
        int number = 0;

        while(number<10)
        {

            int randomValue = Random.Range(1, 101); //1�̻� 100�̸��� ������ ���� �޾� ���ڴ�. (1~100) 
            Debug.Log($" : {randomValue}�Դϴ�!");

            count++;
            if (8 <= count)
            {
                count = 0;
                Debug.Log("Ȯ������ '��û'�� ����!");
            }
            else if (randomValue <= 10)
            {
                Debug.Log("'��û'�� ����!");
                Debug.Log("õ�� �ʱ�ȭ!!!");
                count = 0;
            }
            else if (randomValue <= 30)
            {
                Debug.Log("'��'�� ����!");
                Debug.Log($"{count}ȸ");
            }
            else
            {
                Debug.Log("'ġġ'�� ����!");
                Debug.Log($"{count}ȸ");
            }

            number++;
        }

    }
    public int selectNumber = 0;
    public void GachaSwitch()
    {

        //Ȯ���� 10% -> �α� : '��û'�� ����!

        //Ȯ���� 20% -> �α� : '��'�� ����!

        //Ȯ���� 70% -> �α� : 'ġġ'�� ����!

        int randomValue = Random.Range(1, 101); //1�̻� 100�̸��� ������ ���� �޾� ���ڴ�. (1~100) 

        


        count++;

        switch (selectNumber)
        {
            case 0:
                {
                    if (randomValue <= 10)
                    {
                        Debug.Log("'�������'�� ����!");
                        Debug.Log("õ�� �ʱ�ȭ!!!");
                        count = 0;
                    }
                    else if (randomValue <= 30)
                    {
                        Debug.Log("'�Ұ��'�� ����!");
                        Debug.Log($"{count}ȸ");
                    }
                    else
                    {
                        Debug.Log("'���߸���'�� ����!");
                        Debug.Log($"{count}ȸ");
                    }
                }
                break;

            case 1:
                {
                    if (randomValue <= 10)
                    {
                        Debug.Log("'�����'�� ����!");
                        Debug.Log("õ�� �ʱ�ȭ!!!");
                        count = 0;
                    }
                    else if (randomValue <= 30)
                    {
                        Debug.Log("'�Ұ��'�� ����!");
                        Debug.Log($"{count}ȸ");
                    }
                    else
                    {
                        Debug.Log("'���߸���'�� ����!");
                        Debug.Log($"{count}ȸ");
                    }
                }
                break;

            default:
                {
                    if (randomValue <= 10)
                    {
                        Debug.Log("'�߰��'�� ����!");
                        Debug.Log("õ�� �ʱ�ȭ!!!");
                        count = 0;
                    }
                    else if (randomValue <= 30)
                    {
                        Debug.Log("'�Ұ��'�� ����!");
                        Debug.Log($"{count}ȸ");
                    }
                    else
                    {
                        Debug.Log("'���߸���'�� ����!");
                        Debug.Log($"{count}ȸ");
                    }
                }
                break;
        }

        if (8 <= count)
        {
            count = 0;
            Debug.Log("Ȯ������ '��û'�� ����!");
        }



    }

}
