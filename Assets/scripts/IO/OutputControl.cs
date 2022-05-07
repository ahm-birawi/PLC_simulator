using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutputControl : MonoBehaviour
{
    public VirtualPLC.PLC plc;
    private void Start()
    {
        plc = GameObject.Find("Build_button").GetComponent<VPLCBuild>().plc;
    }
    void Update()
    {
        if (!GameObject.Find("Build_button").GetComponent<VPLCBuild>().isRuning)
            return;
        if (plc.InputOutputFile[1, 0])
            transform.GetChild(0).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(0).GetComponent<Image>().color = Color.red;
        if (plc.InputOutputFile[1, 1])
            transform.GetChild(1).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(1).GetComponent<Image>().color = Color.red;
        if (plc.InputOutputFile[1, 2])
            transform.GetChild(2).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(2).GetComponent<Image>().color = Color.red;
        if (plc.InputOutputFile[1, 3])
            transform.GetChild(3).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(3).GetComponent<Image>().color = Color.red;
        if (plc.InputOutputFile[1, 4])
            transform.GetChild(4).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(4).GetComponent<Image>().color = Color.red;
        if (plc.InputOutputFile[1, 5])
            transform.GetChild(5).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(5).GetComponent<Image>().color = Color.red;
        if (plc.InputOutputFile[1, 6])
            transform.GetChild(6).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(6).GetComponent<Image>().color = Color.red;
        if (plc.InputOutputFile[1, 7])
            transform.GetChild(7).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(7).GetComponent<Image>().color = Color.red;
        if (plc.InputOutputFile[1, 8])
            transform.GetChild(8).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(8).GetComponent<Image>().color = Color.red;
        if (plc.InputOutputFile[1, 9])
            transform.GetChild(9).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(9).GetComponent<Image>().color = Color.red;
        if (plc.InputOutputFile[1, 10])
            transform.GetChild(10).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(10).GetComponent<Image>().color = Color.red;
        if (plc.InputOutputFile[1, 11])
            transform.GetChild(11).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(11).GetComponent<Image>().color = Color.red;
        if (plc.InputOutputFile[1, 12])
            transform.GetChild(12).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(12).GetComponent<Image>().color = Color.red;
        if (plc.InputOutputFile[1, 13])
            transform.GetChild(13).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(13).GetComponent<Image>().color = Color.red;
        if (plc.InputOutputFile[1, 14])
            transform.GetChild(14).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(14).GetComponent<Image>().color = Color.red;
        if (plc.InputOutputFile[1, 15])
            transform.GetChild(15).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(15).GetComponent<Image>().color = Color.red;

    }
}
