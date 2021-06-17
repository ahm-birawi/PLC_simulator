using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutputControl : MonoBehaviour
{
    PLC PLC;
    private void Start()
    {
        PLC = GameObject.Find("ProgrammingArea").GetComponent<PLC>();
    }
    void Update()
    {
        if (PLC.P[16].state)
            transform.GetChild(0).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(0).GetComponent<Image>().color = Color.red;
        if (PLC.P[17].state)
            transform.GetChild(1).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(1).GetComponent<Image>().color = Color.red;
        if (PLC.P[18].state)
            transform.GetChild(2).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(2).GetComponent<Image>().color = Color.red;
        if (PLC.P[19].state)
            transform.GetChild(3).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(3).GetComponent<Image>().color = Color.red;
        if (PLC.P[20].state)
            transform.GetChild(4).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(4).GetComponent<Image>().color = Color.red;
        if (PLC.P[21].state)
            transform.GetChild(5).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(5).GetComponent<Image>().color = Color.red;
        if (PLC.P[22].state)
            transform.GetChild(6).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(6).GetComponent<Image>().color = Color.red;
        if (PLC.P[23].state)
            transform.GetChild(7).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(7).GetComponent<Image>().color = Color.red;
        if (PLC.P[24].state)
            transform.GetChild(8).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(8).GetComponent<Image>().color = Color.red;
        if (PLC.P[25].state)
            transform.GetChild(9).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(9).GetComponent<Image>().color = Color.red;
        if (PLC.P[26].state)
            transform.GetChild(10).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(10).GetComponent<Image>().color = Color.red;
        if (PLC.P[27].state)
            transform.GetChild(11).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(11).GetComponent<Image>().color = Color.red;
        if (PLC.P[28].state)
            transform.GetChild(12).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(12).GetComponent<Image>().color = Color.red;
        if (PLC.P[29].state)
            transform.GetChild(13).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(13).GetComponent<Image>().color = Color.red;
        if (PLC.P[30].state)
            transform.GetChild(14).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(14).GetComponent<Image>().color = Color.red;
        if (PLC.P[31].state)
            transform.GetChild(15).GetComponent<Image>().color = Color.green;
        else
            transform.GetChild(15).GetComponent<Image>().color = Color.red;

    }
}
