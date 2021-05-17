using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smaller_equ : MonoBehaviour
{
    public Bit Compare_result = new Bit();
    // Start is called before the first frame update
    Transform inputfield0;
    Transform inputfield1;
    void Start()
    {
        inputfield0 = transform.GetChild(0);
        inputfield1 = transform.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Run_button").GetComponent<Run>().run)
        {
            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().D[int.Parse(inputfield0.GetComponent<InputField>().text)] <=
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().D[int.Parse(inputfield1.GetComponent<InputField>().text)])
            {
                Compare_result.state = true;
            }
            else Compare_result.state = false;
        }
        //Debug.Log(Compare_result.state);
    }
}
