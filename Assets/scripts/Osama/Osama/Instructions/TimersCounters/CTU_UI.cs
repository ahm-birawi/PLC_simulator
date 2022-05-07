using VirtualPLC.Instructions.TimersAndCounters;
using UnityEngine;
using VirtualPLC;

public class CTU_UI : TC
{
    public CTU MyCTU { get; set; }

    private void Start()
    {
        build = GameObject.Find("Build_button").GetComponent<VPLCBuild>();
        MyCTU = new CTU();
    }
    public override void Setup()
    {
        MyCTU.MainAddress = "C" + adress.text;
        build.plc.CounterFile[Address.GetTimerCounterNumber("C" + adress.text)].PRE = short.Parse(presetText.text);
        MyInstruction = MyCTU;
    }
}
