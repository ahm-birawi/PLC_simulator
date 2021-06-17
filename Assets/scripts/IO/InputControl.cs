using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour
{
    PLC PLC;
    private void Start()
    {
        PLC = GameObject.Find("ProgrammingArea").GetComponent<PLC>();
    }
    public void P0()
    {

        PLC.P[0].state = !PLC.P[0].state;

    }
    public void P1()
    {

        PLC.P[1].state = !PLC.P[1].state;

    }
    public void P2()
    {

        PLC.P[2].state = !PLC.P[2].state;

    }
    public void P3()
    {

        PLC.P[3].state = !PLC.P[3].state;

    }
    public void P4()
    {

        PLC.P[4].state = !PLC.P[4].state;

    }
    public void P5()
    {

        PLC.P[5].state = !PLC.P[5].state;

    }
    public void P6()
    {

        PLC.P[6].state = !PLC.P[6].state;

    }
    public void P7()
    {

        PLC.P[7].state = !PLC.P[7].state;

    }
    public void P8S()
    {

        PLC.P[8].state = true;

    }
    public void P8R()
    {
        PLC.P[8].state = false;
    }
    public void P9S()
    {

        PLC.P[9].state = true;

    }
    public void P9R()
    {
        PLC.P[9].state = false;
    }
    public void P10S()
    {

        PLC.P[10].state = true;

    }
    public void P10R()
    {
        PLC.P[10].state = false;
    }
    public void P11S()
    {

        PLC.P[11].state = true;

    }
    public void P11R()
    {
        PLC.P[11].state = false;
    }
    public void P12S()
    {

        PLC.P[12].state = true;

    }
    public void P12R()
    {
        PLC.P[12].state = false;
    }
    public void P13S()
    {

        PLC.P[13].state = true;

    }
    public void P13R()
    {
        PLC.P[13].state = false;
    }
    public void P14S()
    {

        PLC.P[14].state = true;

    }
    public void P14R()
    {
        PLC.P[14].state = false;
    }
    public void P15S()
    {

        PLC.P[15].state = true;

    }
    public void P15R()
    {
        PLC.P[15].state = false;
    }
}

