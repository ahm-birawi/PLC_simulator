using VirtualPLC.Instructions.Comparison;

public class GEQ_UI : TwoAddInst
{
    public GEQ MyGEQ { get; set; }

    private void Start()
    {
        MyGEQ = new GEQ();
    }

    public override void Setup()
    {
        address1 = addrs1.text;
        address2 = addrs2.text;
        MyGEQ.MainAddress = address1;
        MyGEQ.SubAddress = address2;
        MyInstruction = MyGEQ;
    }
}
