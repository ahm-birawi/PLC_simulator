using UnityEngine;
using VirtualPLC.Instructions;
using VirtualPLC.Instructions.Abilities;
using VirtualPLC.Instructions.BooleanOperators;

public class VPLC_ORBuild : MonoBehaviour
{
    public OrOperator BuildOr(VirtualPLC.Instructions.Rung currentRung)
    {
        Transform minirung1transform = transform.GetChild(0);
        Transform minirung2transform = transform.GetChild(4);
        OrOperator orOperator = new OrOperator();
        orOperator.LeftChild = Build(minirung1transform, currentRung);
        orOperator.RightChild = Build(minirung2transform, currentRung);

        return orOperator;
    }

    Instruction Build(Transform rung, VirtualPLC.Instructions.Rung currentRung)
    {
        if (rung.childCount == 1)
        {
            //Debug.Log(VPLCBuild.GetInstruction(rung.GetChild(0), currentRung));
            currentRung.ReadingSet.Add((IICanRead)VPLCBuild.GetInstruction(rung.GetChild(0), currentRung));
            return VPLCBuild.GetInstruction(rung.GetChild(0), currentRung);
        }
        AndOperator rungAnd = new AndOperator();
        AndOperator prevAnd;
        AndOperator currentAnd;

        //left side of the 
        currentAnd = rungAnd;
        foreach (Transform inst in rung.transform)
        {
            prevAnd = currentAnd;
            currentAnd = new AndOperator();
            //if not last intruction on the rung
            if (!(inst.GetSiblingIndex() == rung.transform.childCount - 1))
            {
                prevAnd.LeftChild = currentAnd;
                //Debug.Log(VPLCBuild.GetInstruction(inst, currentRung));
                currentRung.ReadingSet.Add((IICanRead)VPLCBuild.GetInstruction(inst, currentRung));
                currentAnd.RightChild = VPLCBuild.GetInstruction(inst, currentRung);
            }
            else
                prevAnd.LeftChild = VPLCBuild.GetInstruction(inst, currentRung);
        }
        return rungAnd;
    }

}
