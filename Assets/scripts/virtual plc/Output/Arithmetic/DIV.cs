using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DIV : MonoBehaviour
{
    public Text resulttxt;
    Transform inputfield0;
    Transform inputfield1;
    Transform inputfield2;
    short result;
    private void Start()
    {

        inputfield0 = transform.GetChild(0);
        inputfield1 = transform.GetChild(1);
        inputfield2 = transform.GetChild(2);
    }

    // Update is called once per frame
    void Update()
    {
        
            int address0 = int.Parse(inputfield0.GetComponent<InputField>().text.Substring(1));
            int address1 = int.Parse(inputfield1.GetComponent<InputField>().text.Substring(1));
            int address2 = int.Parse(inputfield2.GetComponent<InputField>().text.Substring(1));
            result = (short)(GameObject.Find("ProgrammingArea").GetComponent<PLC>().D[address0] / GameObject.Find("ProgrammingArea").GetComponent<PLC>().D[address1]);
            GameObject.Find("ProgrammingArea").GetComponent<PLC>().D[address2] = result;
            Debug.Log((short)result);
            resulttxt.text = result.ToString();
        
    }
}
