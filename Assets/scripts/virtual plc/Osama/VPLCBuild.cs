using System.Collections.Generic;
using UnityEngine;
using VirtualPLC.Instructions;
using VirtualPLC.Instructions.Abilities;
using VirtualPLC.Instructions.BooleanOperators;

public class VPLCBuild : MonoBehaviour
{
    public VirtualPLC.PLC plc;
    GameObject[] rungsUI;
    public bool isRuning = false;
    List<VirtualPLC.Instructions.Rung> program = new List<VirtualPLC.Instructions.Rung>();
    private void Awake()
    {
        plc = new VirtualPLC.PLC();
    }

    public void BuildProgram()
    {
        rungsUI = GameObject.FindGameObjectsWithTag("Input_Panel");
        plc.LadderDiagram.Clear();
        foreach (GameObject rung in rungsUI)
        {
            VirtualPLC.Instructions.Rung currentRung = new Rung();
            AndOperator prevAnd;
            AndOperator currentAnd;

            //right side of the rung (output instruction)
            Instruction_UI outInstuction = rung.transform.parent.GetChild(1)
                .GetComponentInChildren<Instruction_UI>();
            Debug.Log(outInstuction);
            outInstuction.Setup();
            currentRung.EvaluatingEntryElement.RightChild = outInstuction.MyInstruction;
            currentRung.WritingElement = (IICanWrite)outInstuction.MyInstruction;

            //left side of the 
            currentAnd = currentRung.EvaluatingEntryElement;
            foreach (Transform inst in rung.transform)
            {
                //Debug.Log(GetInstruction(inst, currentRung));
                if (!inst.CompareTag("OR"))
                    currentRung.ReadingSet.Add((IICanRead)GetInstruction(inst, currentRung));
                prevAnd = currentAnd;
                currentAnd = new AndOperator();
                //if not last intruction on the rung
                if (!(inst.GetSiblingIndex() == rung.transform.childCount - 1))
                {
                    prevAnd.LeftChild = currentAnd;
                    currentAnd.RightChild = GetInstruction(inst, currentRung);
                }
                else
                    prevAnd.LeftChild = GetInstruction(inst, currentRung);
            }
            plc.LadderDiagram.Add(currentRung);
        }
        Debug.Log(plc.LadderDiagram.Count);
    }
    public static Instruction GetInstruction(Transform inst, VirtualPLC.Instructions.Rung currentRung)
    {
        if (!inst.CompareTag("OR"))
        {
            Instruction_UI instComponent = inst.GetComponent<Instruction_UI>();
            instComponent.Setup();
            return instComponent.MyInstruction;
        }
        //if or
        VPLC_ORBuild vPLC_ORBuild = inst.GetComponent<VPLC_ORBuild>();
        OrOperator orObject = vPLC_ORBuild.BuildOr(currentRung);
        return orObject;
    }
}
