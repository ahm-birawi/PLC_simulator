using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TRTG : MonoBehaviour
{
    Transform inputfield0;
    public float acc = 0f;
    public float preset = 0f;
    bool last_stat = false;

    private void Start()
    {
        inputfield0 = transform.GetChild(0);
        preset = float.Parse(transform.GetChild(1).GetComponent<InputField>().text);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Run_button").GetComponent<Run>().run)
        {
            if (GetComponentInParent<Rung_Out>().output && !last_stat )
            {
                Debug.Log("acc=pre");
                acc = preset / 100;       //prest in mili sec
            }
            else if (acc > 0)
            {
                Debug.Log("acc decresong");
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().T[int.Parse(inputfield0.GetComponent<InputField>().text)].state = true;
                acc -= Time.deltaTime;
            }
            if (acc <= 0) GameObject.Find("ProgrammingArea").GetComponent<PLC>().T[int.Parse(inputfield0.GetComponent<InputField>().text)].state = false;
            Debug.Log(acc + " " + int.Parse(inputfield0.GetComponent<InputField>().text));
            last_stat = GetComponentInParent<Rung_Out>().output;
        }


    }
}
