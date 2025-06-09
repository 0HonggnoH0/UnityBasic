using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayList : MonoBehaviour
{
    int[]numbers = new int[3];
    
    List<int> numberList = new List<int>();

    private void Start()
    {
        numbers[0] = 50;    
        numbers[1] = 100;    
        numbers[2] = 200;    
        numbers[3] = 300;    
        numbers[4] = 400;    
    }

    
}
