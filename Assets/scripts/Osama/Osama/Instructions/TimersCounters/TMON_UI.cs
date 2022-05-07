using VirtualPLC.Instructions.TimersAndCounters;
using UnityEngine;
using VirtualPLC;

public class TMON_UI : TC
{
    public TMON MyTMON { get; set; }

    private void Start()
    {
        build = GameObject.Find("Build_button").GetComponent<VPLCBuild>();
        MyTMON = new TMON(build.plc);
    }
    public override void Setup()
    {
        MyTMON.MainAddress = "T" + adress.text;
        build.plc.TimerFile[Address.GetTimerCounterNumber("T" + adress.text)].PRE = ushort.Parse(presetText.text);
        MyInstruction = MyTMON;
    }
}
