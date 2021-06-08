using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Run : MonoBehaviour
{

    public Text stoptext;    
    public Text runtext;
    public bool rungout;
    public bool run = false;
    public void toggole_run()
    {
        List<Transform> Rung_out = GameObject.Find("Build_button").GetComponent<Build>().Rungs_output;
        var inputfields = GameObject.FindGameObjectsWithTag("InputField");

        run = !run;
        if (run)
        {
            foreach (var inputfield in inputfields)
            {
                inputfield.GetComponent<InputField>().readOnly = true;
            }
            stoptext.gameObject.SetActive(true);
            runtext.gameObject.SetActive(false);
            foreach (Transform rout in Rung_out)
            {
                if (rout.GetChild(0).tag == "Coil") rout.GetChild(0).GetComponent<normall_out>().enabled = true;
                else if (rout.GetChild(0).tag == "Rcoil") rout.GetChild(0).GetComponent<out_reset>().enabled = true;
                else if (rout.GetChild(0).tag == "Scoil") rout.GetChild(0).GetComponent<Out_Set>().enabled = true;
                else if (rout.GetChild(0).tag == "*") rout.GetChild(0).GetComponent<MUL>().enabled = true;
                else if (rout.GetChild(0).tag == "-") rout.GetChild(0).GetComponent<SUB>().enabled = true;
                else if (rout.GetChild(0).tag == "+") rout.GetChild(0).GetComponent<ADD>().enabled = true;
                else if (rout.GetChild(0).tag == "di") rout.GetChild(0).GetComponent<DIV>().enabled = true;
                else if (rout.GetChild(0).name == "TON") rout.GetChild(0).GetComponent<TON>().enabled = true;
            }
        }
        if (!run)
        {
            foreach (var inputfield in inputfields)
            {
                inputfield.GetComponent<InputField>().readOnly = false;
            }
            stoptext.gameObject.SetActive(false);
            runtext.gameObject.SetActive(true);
            foreach (Transform rout in Rung_out)
            {
                if (rout.GetChild(0).tag == "Coil") rout.GetChild(0).GetComponent<normall_out>().enabled = false;
                if (rout.GetChild(0).tag == "Rcoil") rout.GetChild(0).GetComponent<out_reset>().enabled = false;
                if (rout.GetChild(0).tag == "Scoil") rout.GetChild(0).GetComponent<Out_Set>().enabled = false;
                if (rout.GetChild(0).tag == "*") rout.GetChild(0).GetComponent<MUL>().enabled = false;
                if (rout.GetChild(0).tag == "-") rout.GetChild(0).GetComponent<SUB>().enabled = false;
                if (rout.GetChild(0).tag == "+") rout.GetChild(0).GetComponent<ADD>().enabled = false;
                if (rout.GetChild(0).tag == "di") rout.GetChild(0).GetComponent<DIV>().enabled = false;
                else if (rout.GetChild(0).name == "TON") rout.GetChild(0).GetComponent<TON>().enabled = false;

            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (run)
        {

            List<List<Bit>> program = GameObject.Find("Build_button").GetComponent<Build>().program;
            List<Transform> Rung_out = GameObject.Find("Build_button").GetComponent<Build>().Rungs_output;
            PLC current_stat = GameObject.Find("ProgrammingArea").GetComponent<PLC>();  //Fetching vertual PLC memory   

            int index = 0;
            foreach (List<Bit> rung in program)
            {
                rungout = true;
                foreach (Bit instruction in rung)
                {
                    if (!instruction.state) rungout = false;
                }

                Rung_out[index].GetComponent<Rung_Out>().output = rungout;

                index += 1;
            }
            


        }
    }
  
}
