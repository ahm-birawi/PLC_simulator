using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;

public class Build : MonoBehaviour
{
    PLC PLC;
    public List<List<Bit>> program = new List<List<Bit>>();
    public List<Transform> Rungs_output = new List<Transform>();
    private void Start()
    {
        PLC = GameObject.Find("ProgrammingArea").GetComponent<PLC>();
    }
    /*private void Update()
   {
        foreach (List<Bit> rung in program)
        {
            foreach (Bit instrcution in rung)
            {
                Debug.Log(instrcution.state);
            }
        }
    }*/
    public void build()
    {
        var rungs = GameObject.FindGameObjectsWithTag("Input_Panel");
        foreach(var rung in rungs)
        {

            List<Bit> this_rung = new List<Bit>();
            foreach (Transform child in rung.transform)
            {
                this_rung.Add(redirect(child));
            }
            program.Add(this_rung);

            Transform OutputPanel = rung.transform.parent.GetChild(1);
            Rungs_output.Add(OutputPanel);
            
        }
    }

    Bit redirect (Transform inst)
    {
        /*if (inst.tag == "OR")
        {
            return(parallel(inst));
        }*/
        if (inst.tag.Substring(0, 1) == ":") 
            return (TwoInputfield(inst));

        else if (inst.tag == "OR")
        {
            inst.GetComponent<Or>().BuildOr();
            return inst.GetComponent<Or>().or_out;
        }

        else 
            return OneInputfield(inst);
        

    }

    Bit OneInputfield(Transform instruction_transform)
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


