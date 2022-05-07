using VirtualPLC.Instructions.TimersAndCounters;
using UnityEngine;
using VirtualPLC;

public class TOFF_UI : TC
{
    public TOFF MyTOFF { get; set; }

    private void Start()
    {
        build = GameObject.Find("Build_button").GetComponent<VPLCBuild>();
        MyTOFF = new TOFF(build.plc);
    }
    public override void Setup()
    {
        MyTOFF.MainAddress = "T" + adress.text;
        build.plc.TimerFile[Address.GetTimerCounterNumber("T" + adress.text)].PRE = ushort.Parse(presetText.text);
        MyInstruction = MyTOFF;
    }
}
