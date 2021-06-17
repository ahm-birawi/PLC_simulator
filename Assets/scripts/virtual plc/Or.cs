using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Or : MonoBehaviour
{
    public bool testout;
    public Bit or_out = new Bit();
    Transform minirung1transform;
    Transform minirung2transform;
    List<bool> minirung1bool;
    List<bool> minirung2bool;
    List<Bit> minirung1;
    List<Bit> minirung2;
    public bool minirung1out;
    public bool minirung2out;
    
    PLC PLC;
    // Start is called before the first frame update
    void Start()
    {
        
        PLC = GameObject.Find("ProgrammingArea").GetComponent<PLC>();
    }


    // Update is called once per frame
    void Update()
    {
        //testout = or_out.state;   
        if (GameObject.Find("Run_button").GetComponent<Run>().run)
        {
            minirung1bool = new List<bool>();
            minirung2bool = new List<bool>();
            foreach(Bit instruction in minirung1)
            {
                minirung1bool.Add(instruction.state);
            }
            foreach (Bit instruction in minirung2)
            {
                minirung2bool.Add(instruction.state);
            }
            if (minirung1bool.Contains(false) && minirung2bool.Contains(false)) or_out.state = false;
            else or_out.state = true;
            minirung1out = !minirung1bool.Contains(false);
            minirung2out = !minirung2bool.Contains(false);
                
        }
    }
    public void BuildOr()
    {
        minirung1transform = transform.GetChild(0);
        minirung2transform = transform.GetChild(4);
        minirung1 = new List<Bit>();
        minirung2 = new List<Bit>();

        
        foreach (Transform instruction in minirung1transform)
        {
            if (instruction.tag.Substring(0, 1) == ":")
            {
                minirung1.Add(TwoInputfield(instruction));
            }
            else if (instruction.tag == "OR")
            {
                instruction.GetComponent<Or>().BuildOr();
                minirung1.Add(instruction.GetComponent<Or>().or_out);
            }
            else
            {
                minirung1.Add(OneInputfield(instruction));
            }
        }
        foreach (Transform instruction in minirung2transform)
        {
            if (instruction.tag.Substring(0, 1) == ":")
            {
                minirung2.Add(TwoInputfield(instruction));
            }
            else if (instruction.tag == "OR")
            {
                instruction.GetComponent<Or>().BuildOr();
                minirung2.Add(instruction.GetComponent<Or>().or_out);
            }
            else
            {
                minirung2.Add(OneInputfield(instruction));
            }
        }
    }
    public Bit OneInputfield(Transform instruction_transform)
    {
        string instruction = instruction_transform.tag + instruction_transform.GetComponentInChildren<InputField>().text;
        if (instruction.Substring(0, 3) == "XIC")
        {
            if (instruction.Substring(3, 1) == "P")
            {
                return PLC.P[Int32.Parse(instruction.Substring(4))];
            }
            else if (instruction.Substring(3, 1) == "T")
            {
                return PLC.T[Int32.Parse(instruction.Substring(4))];
            }
            else if (instruction.Substring(3, 1) == "C")
            {
                return PLC.C[Int32.Parse(instruction.Substring(4))];
            }
            else if (instruction.Substring(3, 1) == "M")
            {
                return PLC.M[Int32.Parse(instruction.Substring(4))];
            }
        }
        else if (instruction.Substring(0, 3) == "XIO")
        {
            if (instruction.Substring(3, 1) == "P")
            {
                return PLC.P[Int32.Parse(instruction.Substring(4))];
            }
            else if (instruction.Substring(3, 1) == "T")
            {
                return PLC.T[Int32.Parse(instruction.Substring(4))];
            }
            else if (instruction.Substring(3, 1) == "C")
            {
                return PLC.C[Int32.Parse(instruction.Substring(4))];
            }
            else if (instruction.Substring(3, 1) == "M")
            {
                return PLC.M[Int32.Parse(instruction.Substring(4))];
            }
        }
        Debug.Log("error");
        return new Bit();
    }

    Bit TwoInputfield(Transform instruction_transform)
    {
        if (instruction_transform.tag == ":>>")
            return instruction_transform.gameObject.GetComponent<Larger>().Compare_result;
        else if (instruction_transform.tag == ":<<")
            return instruction_transform.gameObject.GetComponent<Smaller>().Compare_result;
        else if (instruction_transform.tag == ":<=")
            return instruction_transform.gameObject.GetComponent<Smaller_equ>().Compare_result;
        else if (instruction_transform.tag == ":>=")
            return instruction_transform.gameObject.GetComponent<Largger_equ>().Compare_result;
        else
            return instruction_transform.gameObject.GetComponent<Equ>().Compare_result;
    }
}
