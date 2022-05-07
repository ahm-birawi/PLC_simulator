using VirtualPLC.Instructions.Bit;

public class LOAD_UI : BitInstruction_UI
{
    public LOAD MyLOAD { get; set; }

    private void Start()
    {
        MyLOAD = new LOAD();
    }
    public override void Setup()
    {
        address = text.text;
        MyLOAD.MainAddress = address;
        MyInstruction = MyLOAD;
    }
}