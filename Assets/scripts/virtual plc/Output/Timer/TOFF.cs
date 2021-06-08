using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TOFF : MonoBehaviour
{
    // Start is called before the first frame update
    Transform inputfield0;
    public float acc = 0f;
    public float preset = 0f;

    private void Start()
    {
        inputfield0 = transform.GetChild(0);
        preset = float.Parse(transform.GetChild(1).GetComponent<InputField>().text);
    }
    // Update is called once per frame
    void Update()
    {
        
            if (GetComponentInParent<Rung_Out>().output )
            {
                acc = 0;
                Debug.Log("out true");
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().T[int.Parse(inputfield0.GetComponent<InputField>().text)].state = true;
               
            }
            else if (!GetComponentInParent<Rung_Out>().output && acc <= preset/100) //prest in mili sec
            {
                Debug.Log("start counting");
                acc += Time.deltaTime;
            }
            else
            {
                acc = 0f;
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().T[int.Parse(inputfield0.GetComponent<InputField>().text)].state = false;
            }
        }
        
    
}
