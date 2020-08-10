using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerInputFunc : MonoBehaviour
{
    //Methods for button inputs
    private int OnA()
    {
        Debug.Log("Pressed A");
        return 0;
    }

    private int OnB()
    {
        Debug.Log("Pressed B");
        return 1;
    }

    private int OnX()
    {
        Debug.Log("Pressed X");
        return 2;
    }

    private int OnY()
    {
        Debug.Log("Pressed Y");
        return 3;
    }

    private int OnLB()
    {
        Debug.Log("Pressed LB");
        return  4;
    }

    private int OnRB()
    {
        Debug.Log("Pressed RB");
        return  5;
    }

}
