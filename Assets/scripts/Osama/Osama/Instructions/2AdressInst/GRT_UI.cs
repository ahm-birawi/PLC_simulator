using VirtualPLC.Instructions.Comparison;

public class GRT_UI : TwoAddInst
{
    public GRT MyGRT { get; set; }

    private void Start()
    {
        MyGRT = new GRT();
    }
    public override void Setup()
    {
        address1 = addrs1.text;
        address2 = addrs2.text;
        MyGRT.MainAddress = address1;
        MyGRT.SubAddress = address2;
        MyInstruction = MyGRT;
    }
}
