using VirtualPLC.Instructions.Comparison;

public class LES_UI : TwoAddInst
{
    public LES MyLES { get; set; }

    private void Start()
    {
        MyLES = new LES();
    }
    public override void Setup()
    {
        address1 = addrs1.text;
        address2 = addrs2.text;
        MyLES.MainAddress = address1;
        MyLES.SubAddress = address2;
        MyInstruction = MyLES;
    }
}
