using VirtualPLC.Instructions.Bit;

public class LOADNOT_UI : BitInstruction_UI
{
    public LOADNOT MyLOADNOT { get; set; }

    private void Start()
    {
        MyLOADNOT = new LOADNOT();
    }
    public override void Setup()
    {
        address = text.text;
        MyLOADNOT.MainAddress = address;
        MyInstruction = MyLOADNOT;
    }
}