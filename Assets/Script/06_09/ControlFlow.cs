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
        //확률이 10% -> 로그 : '각청'을 뽑음!

        //확률이 20% -> 로그 : '모나'를 뽑음!

        //확률이 70% -> 로그 : '치치'를 뽑음!

       
        int number = 0;

        while(number<10)
        {

            int randomValue = Random.Range(1, 101); //1이상 100미만의 랜덤한 값을 받아 오겠다. (1~100) 
            Debug.Log($" : {randomValue}입니다!");

            count++;
            if (8 <= count)
            {
                count = 0;
                Debug.Log("확정으로 '각청'을 뽑음!");
            }
            else if (randomValue <= 10)
            {
                Debug.Log("'각청'을 뽑음!");
                Debug.Log("천장 초기화!!!");
                count = 0;
            }
            else if (randomValue <= 30)
            {
                Debug.Log("'모나'를 뽑음!");
                Debug.Log($"{count}회");
            }
            else
            {
                Debug.Log("'치치'를 뽑음!");
                Debug.Log($"{count}회");
            }

            number++;
        }

    }
    public int selectNumber = 0;
    public void GachaSwitch()
    {

        //확률이 10% -> 로그 : '각청'을 뽑음!

        //확률이 20% -> 로그 : '모나'를 뽑음!

        //확률이 70% -> 로그 : '치치'를 뽑음!

        int randomValue = Random.Range(1, 101); //1이상 100미만의 랜덤한 값을 받아 오겠다. (1~100) 

        


        count++;

        switch (selectNumber)
        {
            case 0:
                {
                    if (randomValue <= 10)
                    {
                        Debug.Log("'돼지고기'를 뽑음!");
                        Debug.Log("천장 초기화!!!");
                        count = 0;
                    }
                    else if (randomValue <= 30)
                    {
                        Debug.Log("'소고기'를 뽑음!");
                        Debug.Log($"{count}회");
                    }
                    else
                    {
                        Debug.Log("'메추리알'를 뽑음!");
                        Debug.Log($"{count}회");
                    }
                }
                break;

            case 1:
                {
                    if (randomValue <= 10)
                    {
                        Debug.Log("'말고기'를 뽑음!");
                        Debug.Log("천장 초기화!!!");
                        count = 0;
                    }
                    else if (randomValue <= 30)
                    {
                        Debug.Log("'소고기'를 뽑음!");
                        Debug.Log($"{count}회");
                    }
                    else
                    {
                        Debug.Log("'메추리알'를 뽑음!");
                        Debug.Log($"{count}회");
                    }
                }
                break;

            default:
                {
                    if (randomValue <= 10)
                    {
                        Debug.Log("'닭고기'를 뽑음!");
                        Debug.Log("천장 초기화!!!");
                        count = 0;
                    }
                    else if (randomValue <= 30)
                    {
                        Debug.Log("'소고기'를 뽑음!");
                        Debug.Log($"{count}회");
                    }
                    else
                    {
                        Debug.Log("'메추리알'를 뽑음!");
                        Debug.Log($"{count}회");
                    }
                }
                break;
        }

        if (8 <= count)
        {
            count = 0;
            Debug.Log("확정으로 '각청'을 뽑음!");
        }



    }

}
