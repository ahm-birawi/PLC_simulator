﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CTU : MonoBehaviour
{
    Transform inputfield0;
    Transform inputfield1;
    public float acc = 0f;
    public float preset = 0f;
    float value;
    bool last_stat = false;

    private void Start()
    {
        inputfield0 = transform.GetChild(0);
        inputfield1 = transform.GetChild(1);

    }


    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Run_button").GetComponent<Run>().run)
        {
            if (GetComponentInParent<Rung_Out>().output && !last_stat && acc != preset) 
            {
                acc += 1;
            }
            else if(acc == preset)
            {
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().C[int.Parse(inputfield0.GetComponent<InputField>().text)].state = true;
            }
            last_stat = GetComponentInParent<Rung_Out>().output;
        }
        else
        {
            inputfield0 = transform.GetChild(0);
            inputfield1 = transform.GetChild(1);
            if (float.TryParse(inputfield1.GetComponent<InputField>().text,out value))
            {
                preset = value;
            }
        }
    }
}
