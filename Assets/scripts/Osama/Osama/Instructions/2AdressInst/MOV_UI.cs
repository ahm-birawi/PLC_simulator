using VirtualPLC.Instructions.DataHandling;

public class MOV_UI : TwoAddInst
{
    public MOV MyMOV { get; set; }

    private void Start()
    {
        MyMOV = new MOV();
    }
    public override void Setup()
    {
        address1 = addrs1.text;
        address2 = addrs2.text;
        MyMOV.MainAddress = address1;
        MyMOV.Destination = address2;
        MyInstruction = MyMOV;
    }
}
