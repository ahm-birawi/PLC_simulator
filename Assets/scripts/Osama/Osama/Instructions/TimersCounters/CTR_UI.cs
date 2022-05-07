using VirtualPLC.Instructions.TimersAndCounters;
using UnityEngine;
using VirtualPLC;

public class CTR_UI : TC
{
    public CTR MyCTR { get; set; }

    private void Start()
    {
        build = GameObject.Find("Build_button").GetComponent<VPLCBuild>();
        MyCTR = new CTR();
    }
    public override void Setup()
    {
        MyCTR.MainAddress = "C" + adress.text;
        build.plc.CounterFile[Address.GetTimerCounterNumber("C" + adress.text)].PRE = short.Parse(presetText.text);
        MyInstruction = MyCTR;
    }
}
