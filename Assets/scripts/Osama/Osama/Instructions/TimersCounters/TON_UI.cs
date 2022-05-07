using VirtualPLC.Instructions.TimersAndCounters;
using UnityEngine;
using VirtualPLC;

public class TON_UI : TC
{
    public TON MyTON { get; set; }

    private void Start()
    {
        build = GameObject.Find("Build_button").GetComponent<VPLCBuild>();
        MyTON = new TON(build.plc);
    }
    public override void Setup()
    {
        MyTON.MainAddress = "T" + adress.text;
        build.plc.TimerFile[Address.GetTimerCounterNumber("T"+ adress.text)].PRE =ushort.Parse(presetText.text);
        MyInstruction = MyTON;
    }
}
