using UnityEngine;
using UnityEngine.UI;

public class TC : Instruction_UI
{
    [SerializeField] protected Text adress;
    [SerializeField] protected Text presetText;

    protected VPLCBuild build;
    protected ushort preset;
}