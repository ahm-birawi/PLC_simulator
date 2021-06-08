using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CTR : MonoBehaviour
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
        
            if (GetComponentInParent<Rung_Out>().output && !last_stat && acc != preset)
            {
                acc += 1;
            }
            else if (acc == preset)
            {
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().C[int.Parse(inputfield0.GetComponent<InputField>().text)].state = true;
            }
            else if (GetComponentInParent<Rung_Out>().output && !last_stat && acc == preset)
            {
                acc = 0;
            }
            last_stat = GetComponentInParent<Rung_Out>().output;
        
    }
}
