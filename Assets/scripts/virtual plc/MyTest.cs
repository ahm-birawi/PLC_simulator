﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyTest : MonoBehaviour
{
    public InputField xx = null;
    public bool x;
    public void test()
    {

        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[0].state = !GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[0].state;
        
    }
    public void test1()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[1].state = !GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[1].state;

    }
    
    /*private void Update()
    {
        Debug.Log(GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[10].state);
    }*/

}
