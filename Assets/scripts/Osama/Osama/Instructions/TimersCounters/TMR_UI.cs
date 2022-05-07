using VirtualPLC.Instructions.TimersAndCounters;
using UnityEngine;
using VirtualPLC;

public class TMR_UI : TC
{
    public TMR MyTMR { get; set; }

    private void Start()
    {
        build = GameObject.Find("Build_button").GetComponent<VPLCBuild>();
        MyTMR = new TMR(build.plc);
    }
    public override void Setup()
    {
        MyTMR.MainAddress = "T" + adress.text;
        build.plc.TimerFile[Address.GetTimerCounterNumber("T" + adress.text)].PRE = ushort.Parse(presetText.text);
        MyInstruction = MyTMR;
    }
}
