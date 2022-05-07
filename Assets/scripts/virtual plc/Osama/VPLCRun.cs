using UnityEngine;
using UnityEngine.UI;
using VirtualPLC.Instructions;

public class VPLCRun : MonoBehaviour
{
    [SerializeField] VPLCBuild vPLCBuild;
    [SerializeField] Text runStopText;
    VirtualPLC.PLC plc;
    public void Run()
    {
        plc = vPLCBuild.plc;
        vPLCBuild.isRuning = !vPLCBuild.isRuning;
    }
    private void Update()
    {
        if (vPLCBuild.isRuning)
        {
            runStopText.text = "Stop";
            plc.Scan();
        }
        else
        runStopText.text = "Run";

    }

}
