using VirtualPLC.Instructions.TimersAndCounters;
using UnityEngine;
using VirtualPLC;

public class TRTG_UI : TC
{
    public TRTG MyTRTG { get; set; }

    private void Start()
    {
        build = GameObject.Find("Build_button").GetComponent<VPLCBuild>();
        MyTRTG = new TRTG(build.plc);
    }
    public override void Setup()
    {
        MyTRTG.MainAddress = "T" + adress.text;
        build.plc.TimerFile[Address.GetTimerCounterNumber("T" + adress.text)].PRE = ushort.Parse(presetText.text);
        MyInstruction = MyTRTG;
    }
}
