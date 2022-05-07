using VirtualPLC.Instructions.Bit;

public class RST_UI : BitInstruction_UI
{
    public RST MyRST { get; set; }

    private void Start()
    {
        MyRST = new RST();
    }
    public override void Setup()
    {
        address = text.text;
        MyRST.MainAddress = address;
        MyInstruction = MyRST;
    }
}