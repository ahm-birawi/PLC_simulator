using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TMR : MonoBehaviour
{

    Transform inputfield0;  
    public float acc = 0f;
    public float preset = 0f;
    float value;

    private void Start()
    {
        inputfield0 = transform.GetChild(0);
        preset = float.Parse(transform.GetChild(1).GetComponent<InputField>().text);
    }
    // Update is called once per frame
    void Update()
    {
            if (GetComponentInParent<Rung_Out>().output)
            {
                Debug.Log("out true");
                acc += Time.deltaTime;
                if (acc >= preset / 100)    // the preset is  in mili sec
                {
                    Debug.Log("done");
                    GameObject.Find("ProgrammingArea").GetComponent<PLC>().T[int.Parse(inputfield0.GetComponent<InputField>().text)].state = true;
                }
            }
            else
            {
                Debug.Log("false");
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().T[int.Parse(inputfield0.GetComponent<InputField>().text)].state = false;
                if (acc >= preset/100) 
                {
                    acc = 0f;
                }
            }
            Debug.Log(acc);
    }
}
