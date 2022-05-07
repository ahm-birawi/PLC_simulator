using UnityEngine;

public class InputControl : MonoBehaviour
{
    public VirtualPLC.PLC plc;
    private void Start()
    {
        plc = GameObject.Find("Build_button").GetComponent<VPLCBuild>().plc;
    }
    public void P0()
    {
        plc.InputOutputFile[0, 0] = !plc.InputOutputFile[0, 0];
    }
    public void P1()
    {
        plc.InputOutputFile[0, 1] = !plc.InputOutputFile[0, 1];
    }
    public void P2()
    {
        plc.InputOutputFile[0, 2] = !plc.InputOutputFile[0, 2];
    }
    public void P3()
    {
        plc.InputOutputFile[0, 3] = !plc.InputOutputFile[0, 3];
    }
    public void P4()
    {
        plc.InputOutputFile[0, 4] = !plc.InputOutputFile[0, 4];
    }
    public void P5()
    {
        plc.InputOutputFile[0, 5] = !plc.InputOutputFile[0, 5];
    }
    public void P6()
    {
        plc.InputOutputFile[0, 6] = !plc.InputOutputFile[0, 6];
    }
    public void P7()
    {
        plc.InputOutputFile[0, 7] = !plc.InputOutputFile[0, 7];
    }
    public void P8S()
    {
        plc.InputOutputFile[0, 8] = true;
    }
    public void P8R()
    {
        plc.InputOutputFile[0, 8] = false;
    }
    public void P9S()
    {

        plc.InputOutputFile[0, 9] = true;

    }
    public void P9R()
    {
        plc.InputOutputFile[0, 9] = false;
    }
    public void P10S()
    {

        plc.InputOutputFile[0, 10] = true;

    }
    public void P10R()
    {
        plc.InputOutputFile[0, 10] = false;
    }
    public void P11S()
    {

        plc.InputOutputFile[0, 11] = true;

    }
    public void P11R()
    {
        plc.InputOutputFile[0, 11] = false;
    }
    public void P12S()
    {

        plc.InputOutputFile[0, 12] = true;

    }
    public void P12R()
    {
        plc.InputOutputFile[0, 12] = false;
    }
    public void P13S()
    {

        plc.InputOutputFile[0, 13] = true;

    }
    public void P13R()
    {
        plc.InputOutputFile[0, 13] = false;
    }
    public void P14S()
    {

        plc.InputOutputFile[0, 14] = true;

    }
    public void P14R()
    {
        plc.InputOutputFile[0, 14] = false;
    }
    public void P15S()
    {

        plc.InputOutputFile[0, 15] = true;

    }
    public void P15R()
    {
        plc.InputOutputFile[0, 15] = false;
    }
}

