using UnityEngine;
using UnityEngine.UI;
using VirtualPLC;
public class ADD_UI : ThreeAddInst
{
    VPLCBuild build;

    public VirtualPLC.Instructions.Arithmetic.ADD MyADD { get; set; }
    [SerializeField] Text res;
    private void Start()
    {
        MyADD = new VirtualPLC.Instructions.Arithmetic.ADD();
        build = GameObject.Find("Build_button").GetComponent<VPLCBuild>();
    }
    public override void Setup()
    {
        address1 = addrs1.text;
        address2 = addrs2.text;
        address3 = addrs3.text;
        MyADD.MainAddress = address1;
        MyADD.SubAddress = address2;
        MyADD.Destination = address3;
        MyInstruction = MyADD;
    }
    private void Update()
    {
        if (build.isRuning)
            res.text = Address.ReadFromANumberAddress(build.plc, address3).ToString();
    }
}
