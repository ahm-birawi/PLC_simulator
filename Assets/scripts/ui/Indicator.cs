using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Indicator : MonoBehaviour
{
    PLC PLC;
    InputField input;
    int x;
    private void Start()
    {
        PLC = GameObject.Find("ProgrammingArea").GetComponent<PLC>();
        input = transform.parent.GetComponentInChildren<InputField>();
    }
    void Update()
    {
        if (GameObject.Find("Run_button").GetComponent<Run>().run)
        {
            x = int.Parse(input.text.Substring(1));
            Debug.Log(x);
            if (PLC.P[x].state)
                transform.GetComponent<Image>().color = Color.green;
            else
                transform.GetComponent<Image>().color = Color.red;
        }


    }
}
