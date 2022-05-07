using VirtualPLC.Instructions.TimersAndCounters;
using UnityEngine;
using VirtualPLC;

public class CTD_UI : TC
{
    public CTD MyCTD { get; set; }

    private void Start()
    {
        build = GameObject.Find("Build_button").GetComponent<VPLCBuild>();
        MyCTD = new CTD();
    }
    public override void Setup()
    {
        MyCTD.MainAddress = "C" + adress.text;
        build.plc.CounterFile[Address.GetTimerCounterNumber("C" + adress.text)].PRE = short.Parse(presetText.text);
        MyInstruction = MyCTD;
    }
}
