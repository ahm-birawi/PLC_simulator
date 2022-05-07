using VirtualPLC.Instructions.Comparison;

public class EQU_UI : TwoAddInst
{
    public EQU MyEQU { get; set; }

    private void Start()
    {
        MyEQU = new EQU();
    }
    public override void Setup()
    {
        address1 = addrs1.text;
        address2 = addrs2.text;
        MyEQU.MainAddress = address1;
        MyEQU.SubAddress = address2;
        MyInstruction = MyEQU;
    }
}
