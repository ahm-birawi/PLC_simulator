using VirtualPLC.Instructions.Comparison;

public class LEQ_UI : TwoAddInst
{
    public LEQ MyLEQ { get; set; }

    private void Start()
    {
        MyLEQ = new LEQ();
    }
    public override void Setup()
    {
        address1 = addrs1.text;
        address2 = addrs2.text;
        MyLEQ.MainAddress = address1;
        MyLEQ.SubAddress = address2;
        MyInstruction = MyLEQ;
    }
}
