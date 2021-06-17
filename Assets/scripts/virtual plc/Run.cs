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
    PLC PLC;
    public Text stoptext;    
    public Text runtext;
    public bool rungout;
    public bool run = false; 
    Bit[] false23 = new Bit[32];
    Bit[] false1024 = new Bit[1024];
    private void Start()
    {
        PLC = GameObject.Find("ProgrammingArea").GetComponent<PLC>();

        for (int i = 0; i < 32; i++)
        {
            false23[i] = new Bit();
        }
        for (int i = 0; i < 1024; i++)
        {
            false1024[i] = new Bit();
        }
    }


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
                else if (rout.GetChild(0).name == "TOFF") rout.GetChild(0).GetComponent<TOFF>().enabled = true;
                else if (rout.GetChild(0).name == "TMR") rout.GetChild(0).GetComponent<TMR>().enabled = true;
                else if (rout.GetChild(0).name == "TMON") rout.GetChild(0).GetComponent<TMON>().enabled = true;
                else if (rout.GetChild(0).name == "TRTG") rout.GetChild(0).GetComponent<TRTG>().enabled = true;
                else if (rout.GetChild(0).name == "CTD") rout.GetChild(0).GetComponent<CTD>().enabled = true;
                else if (rout.GetChild(0).name == "CTU") rout.GetChild(0).GetComponent<CTU>().enabled = true;
                else if (rout.GetChild(0).name == "CTR") rout.GetChild(0).GetComponent<CTR>().enabled = true;

            }
            GameObject.Find("Build_button").GetComponent<RectTransform>().sizeDelta=new Vector2(0,0);
            GameObject.Find("t/c reset").GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);


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
                else if (rout.GetChild(0).tag == "Rcoil") rout.GetChild(0).GetComponent<out_reset>().enabled = false;
                else if (rout.GetChild(0).tag == "Scoil") rout.GetChild(0).GetComponent<Out_Set>().enabled = false;
                else if (rout.GetChild(0).tag == "*") rout.GetChild(0).GetComponent<MUL>().enabled = false;
                else if (rout.GetChild(0).tag == "-") rout.GetChild(0).GetComponent<SUB>().enabled = false;
                else if (rout.GetChild(0).tag == "+") rout.GetChild(0).GetComponent<ADD>().enabled = false;
                else if (rout.GetChild(0).tag == "di") rout.GetChild(0).GetComponent<DIV>().enabled = false;
                else if (rout.GetChild(0).name == "TON") rout.GetChild(0).GetComponent<TON>().enabled = false;
                else if (rout.GetChild(0).name == "TOFF") rout.GetChild(0).GetComponent<TOFF>().enabled = false;
                else if (rout.GetChild(0).name == "TMR") rout.GetChild(0).GetComponent<TMR>().enabled = false;
                else if (rout.GetChild(0).name == "TMON") rout.GetChild(0).GetComponent<TMON>().enabled = false;
                else if (rout.GetChild(0).name == "TRTG") rout.GetChild(0).GetComponent<TRTG>().enabled = false;
                else if (rout.GetChild(0).name == "CTD") rout.GetChild(0).GetComponent<CTD>().enabled = false;
                else if (rout.GetChild(0).name == "CTU") rout.GetChild(0).GetComponent<CTU>().enabled = false;
                else if (rout.GetChild(0).name == "CTR") rout.GetChild(0).GetComponent<CTR>().enabled = false;
                PLC.P = false23;
                PLC.M = false1024;

                GameObject.Find("Build_button").GetComponent<RectTransform>().sizeDelta = new Vector2(160, 30);
                GameObject.Find("t/c reset").GetComponent<RectTransform>().sizeDelta = new Vector2(160, 30);
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
