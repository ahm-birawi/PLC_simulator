using VirtualPLC.Instructions.Bit;
using UnityEngine;

public class OUT_UI : BitInstruction_UI
{
    public OUT MyOUT { get; set; }

    private void Start()
    {
        MyOUT = new OUT();
    }
    public override void Setup()
    {
        address = text.text;
        MyOUT.MainAddress = address;
        MyInstruction = MyOUT;
    }
}