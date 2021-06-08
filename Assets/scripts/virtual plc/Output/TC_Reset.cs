using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TC_Reset : MonoBehaviour
{
    PLC PLC;
    Bit[] reseter = new Bit[1024];
    private void Start()
    {
        PLC = GameObject.Find("ProgrammingArea").GetComponent<PLC>();
        for (int i = 0; i < 1024; i++)
        {
            reseter[i] = new Bit();
        }
    }
    public void tc_reset()
    {
        PLC.T = reseter;
        PLC.C = reseter;
        var tcs = GameObject.FindGameObjectsWithTag("TC");
        foreach (var tc in tcs)
        {
            if (tc.name == "TON")
            {
                tc.GetComponent<TON>().acc = 0f;
                tc.GetComponent<TON>().preset = 0f;
            }
            else if (tc.name == "TOFF")
            {
                tc.GetComponent<TOFF>().acc = 0f;
                tc.GetComponent<TOFF>().preset = 0f;
            }
            else if (tc.name == "TMR")
            {
                tc.GetComponent<TMR>().acc = 0f;
                tc.GetComponent<TMR>().preset = 0f;
            }
            else if (tc.name == "TMON")
            {
                tc.GetComponent<TMON>().acc = 0f;
                tc.GetComponent<TMON>().preset = 0f;
            }
            else if (tc.name == "TRTG")
            {
                tc.GetComponent<TRTG>().acc = 0f;
                tc.GetComponent<TRTG>().preset = 0f;
            }
            else if (tc.name == "CTD")
            {
                tc.GetComponent<CTD>().acc = 0f;
                tc.GetComponent<CTD>().preset = 0f;
            }
            else if (tc.name == "CTR")
            {
                tc.GetComponent<CTR>().acc = 0f;
                tc.GetComponent<CTR>().preset = 0f;
            }
            else if (tc.name == "CTU")
            {
                tc.GetComponent<CTU>().acc = 0f;
                tc.GetComponent<CTU>().preset = 0f;
            }
        }

    }
}
