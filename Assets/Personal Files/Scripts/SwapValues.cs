using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapValues : MonoBehaviour
{
    [SerializeField] private int number1, number2;
    private int temp;

    void OnEnable() => SwapNumbers();

    void SwapNumbers()
    {
        Debug.Log("Number 1 is " + number1);
        Debug.Log("Number 2 is " + number2);

        temp = number1;
        number1 = number2;
        number2 = temp;

        Debug.Log("Number 1 now is: " + number1);
        Debug.Log("Number 2 now is: " + number2);
    }

}
