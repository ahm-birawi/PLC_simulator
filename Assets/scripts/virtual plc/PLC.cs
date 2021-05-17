using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLC : MonoBehaviour
{
    public Bit[] P = new Bit[32];
    public Bit[] M = new Bit[1024];
    public Bit[] T = new Bit[1024];
    public Bit[] C = new Bit[1024];
    public short[] D = new short[5120];
    public Dictionary<string, bool> F = new Dictionary<string, bool>();
    private void Start()
    {
        F.Add("zero", false);
        F.Add("overflow", false);
        F.Add("carry", false);
        for (int i = 0; i < 32; i++)
        {
            P[i] = new Bit();
        }
        for (int i = 0; i < 1024; i++)
        {
            M[i] = new Bit();
            T[i] = new Bit();
            C[i] = new Bit();
        }
    }

    

}
public class Bit
{
    public bool state = false;
}








