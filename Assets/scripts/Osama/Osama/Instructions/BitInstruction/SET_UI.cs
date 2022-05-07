using VirtualPLC.Instructions.Bit;

public class SET_UI : BitInstruction_UI
{
    public SET Myset { get; set; }

    private void Start()
    {
        Myset = new SET();
    }
    public override void Setup()
    {
        address = text.text;
        Myset.MainAddress = address;
        MyInstruction = Myset;

    }
}